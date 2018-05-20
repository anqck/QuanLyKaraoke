using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class VietnameseEditorsLocalizer: Localizer
    {
        public override string Language { get { return "Vietnamese"; } }
        public override string GetLocalizedString(StringId id)
        {
            switch (id)
            {
                // ... 
                case StringId.NavigatorTextStringFormat: return "Zeile {0} von {1}";
                case StringId.PictureEditMenuCut: return "Ausschneiden";
                case StringId.PictureEditMenuCopy: return "Kopieren";
                case StringId.PictureEditMenuPaste: return "Einfugen";
                case StringId.PictureEditMenuDelete: return "Loschen";
                case StringId.PictureEditMenuLoad: return "Laden";
                case StringId.PictureEditMenuSave: return "Speichern";
                case StringId.FilterClauseLess: return "Nhỏ hơn";
                case StringId.FilterClauseBeginsWith: return "Bắt đầu với";
                case StringId.FilterEditorTabVisual: return "Trực quan";
                case StringId.FilterEditorTabText: return "Văn bản";
                default:
                    return base.GetLocalizedString(id);
                    // ... 
            }
            return "";
        }
    }
}
