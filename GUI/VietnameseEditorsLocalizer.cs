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
                case StringId.FilterGroupAnd: return "Và";
                case StringId.FilterGroupOr: return "Hoặc";
                case StringId.FilterGroupNotAnd: return "Không và";
                case StringId.FilterGroupNotOr: return "Không hoặc";
                case StringId.FilterMenuClearAll: return "Xóa tất cả";
                case StringId.FilterMenuGroupAdd: return "Thêm nhóm";
                case StringId.FilterMenuConditionAdd: return "Thêm điều kiện";
                case StringId.FilterClauseEquals: return "Bằng";
                case StringId.FilterClauseDoesNotEqual: return "Không bằng";
                case StringId.FilterClauseContains: return "Chứa";
                case StringId.FilterClauseDoesNotContain: return "Không chứa";
                case StringId.FilterClauseBetween: return "Giữa";
                case StringId.FilterClauseBetweenAnd: return "và";
                case StringId.FilterClauseNotBetween: return "Không giữa";
                case StringId.FilterClauseEndsWith: return "Kết thức với";
                case StringId.FilterClauseGreater: return "Lớn hơn";
                case StringId.FilterClauseGreaterOrEqual: return "Lớn hơn hoặc bằng";
                case StringId.FilterClauseLessOrEqual: return "Bé hơn hoặc bằng";
                case StringId.FilterClauseLike: return "Giống";
                case StringId.FilterClauseNotLike: return "Không giống";
                case StringId.FilterClauseIsNull: return "Rỗng";
                case StringId.FilterClauseIsNotNull: return "Không rỗng";
                case StringId.FilterClauseNoneOf: return "Không phải của";
                case StringId.FilterClauseIsNullOrEmpty: return "Rỗng hoặc trống";
                case StringId.FilterClauseIsNotNullOrEmpty: return "Không rỗng hoặc trống";
                case StringId.FilterClauseAnyOf: return "Bất kỳ của";
                case StringId.FilterEmptyEnter: return "Nhập giá trị";
                default:
                    return base.GetLocalizedString(id);
                    // ... 
            }
            return "";
        }
    }
}
