using System.Linq;
using Microsoft.Vbe.Interop;
using Rubberduck.VBEditor.VBEHost;

namespace Rubberduck.VBEditor.Extensions
{
    public static class VbeExtensions
    {
        public static void SetSelection(this VBE vbe, VBProject vbProject, Selection selection, string name)
        {
            var project = vbe.VBProjects.Cast<VBProject>()
                             .SingleOrDefault(p => p.Protection != vbext_ProjectProtection.vbext_pp_locked 
                                               && ReferenceEquals(p, vbProject));

            VBComponent component = null;
            if (project != null)
            {
                component = project.VBComponents.Cast<VBComponent>()
                    .SingleOrDefault(c => c.Name == name);
            }

            if (component == null)
            {
                return;
            }

            component.CodeModule.CodePane.SetSelection(selection);
        }

        public static CodeModuleSelection FindInstruction(this VBE vbe, QualifiedModuleName qualifiedModuleName, Selection selection)
        {
            var module = qualifiedModuleName.Component.CodeModule;
            if (module == null)
            {
                return null;
            }

            return new CodeModuleSelection(module, selection);
        }

        /// <summary> Returns the type of Office Application that is hosting the VBE. </summary>
        /// <returns> Returns null if Unit Testing does not support Host Application.</returns>
        public static IHostApplication HostApplication(this VBE vbe)
        {
            foreach (var reference in vbe.ActiveVBProject.References.Cast<Reference>()
                .Where(reference => reference.BuiltIn && reference.Name != "VBA"))
            {
                switch (reference.Name)
                {
                    case "Excel":
                        return new ExcelApp();
                    case "Access":
                        return new AccessApp();
                    case "Word":
                        return new WordApp();
                    case "PowerPoint":
                        return new PowerPointApp();
                    case "Outlook":
                        return new OutlookApp();
                    case "Publisher":
                        return new PublisherApp();
                }
            }

            return null;
        }
    }
}