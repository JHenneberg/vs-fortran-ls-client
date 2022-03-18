using System.ComponentModel;

namespace FortranLanguageClient
{
    internal class GeneralOptions : BaseOptionModel<GeneralOptions>
    {
        [Category("Fortran Language Server path")]
        [DisplayName("Fortran Language Server path")]
        [Description("Absolute path to fortls.exe")]
        [DefaultValue("absolute_path\\to\\fortls.exe")]
        public string FortlsPath { get; set; } = "absolute_path\\to\\fortls.exe";

        //  Autocomplete
        [Category("Autocomplete")]
        [DisplayName("--autocomplete_no_prefix")]
        [Description("Do not filter autocomplete results by variable prefix")]
        [DefaultValue(true)]
        public bool AutocompleteNoPrefix { get; set; } = true;

        [Category("Autocomplete")]
        [DisplayName("--autocomplete_no_snippets")]
        [Description("Do not use snippets with place holders in autocomplete results")]
        [DefaultValue(true)]
        public bool AutocompleteNoSnippets { get; set; } = true;

        [Category("Autocomplete")]
        [DisplayName("--autocomplete_name_only")]
        [Description("Complete only the name of procedures and not the parameters")]
        [DefaultValue(false)]
        public bool AutocompleteNameOnly { get; set; } = false;

        [Category("Autocomplete")]
        [DisplayName("--lowercase_intrinsics")]
        [Description("Use lowercase for intrinsics and keywords in autocomplete requests")]
        [DefaultValue(false)]
        public bool AutocompleteLowercaseIntrinsics { get; set; } = false;

        [Category("Autocomplete")]
        [DisplayName("--use_signature_help")]
        [Description("Use signature help instead of subroutine/function snippets. This effectively sets --autocomplete_no_snippets")]
        [DefaultValue(false)]
        public bool AutocompleteSignatureHelp { get; set; } = false;

        //  Hover Options
        [Category("Hover")]
        [DisplayName("--variable_hover")]
        [Description("DEPRECATED: This option is always on. Show hover information for variables")]
        [DefaultValue(true)]
        public bool HoverVariable { get; set; } = true;

        [Category("Hover")]
        [DisplayName("--hover_signature")]
        [Description("Show signature information in hover for arguments")]
        [DefaultValue(true)]
        public bool HoverSignature { get; set; } = true;
    }
}
