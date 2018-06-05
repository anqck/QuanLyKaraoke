using DevExpress.XtraScheduler.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class VietnameseSchedulerLocalizer : SchedulerLocalizer
    {
        public override string Language { get { return "Vietnamese"; } }
        public override string GetLocalizedString(SchedulerStringId id)
        {
            string res = "";
            switch (id)
            {
                case SchedulerStringId.Caption_NextAppointment: return "Đặt phòng kế tiếp";
                case SchedulerStringId.Caption_PrevAppointment: return "Đặt phòng trước đó";
                // ...  
                //case GridStringId.GridGroupPanelText: return "Ziehen Sie eine Spaltenüberschrift in diesen Bereich, um nach dieser zu gruppieren";
                //case GridStringId.MenuColumnClearSorting: return "Sortierung entfernen";
                //case GridStringId.MenuGroupPanelHide: return "Gruppierungsfeld ausblenden";
                //case GridStringId.MenuColumnRemoveColumn: return "Spalte entfernen";
                //case GridStringId.MenuColumnFilterEditor: return "Filter &bearbeiten";
                //case GridStringId.MenuColumnFindFilterShow: return "Suche einblenden";
                //case GridStringId.MenuColumnAutoFilterRowShow: return "Zeige Auto Filterzeile";
                //case GridStringId.MenuColumnSortAscending: return "Aufsteigend sortieren";
                //case GridStringId.MenuColumnSortDescending: return "Absteigend sortieren";
                //case GridStringId.MenuColumnGroup: return "Gruppieren fur dieses Feld";
                //case GridStringId.MenuColumnUnGroup: return "Gruppierung aufheben";
                //case GridStringId.MenuColumnColumnCustomization: return "Laufzeit benutzerdefinierte Spalte";
                //case GridStringId.MenuColumnBestFit: return "Optimale Breite";
                //case GridStringId.MenuColumnFilter: return "Kann gruppieren";
                //case GridStringId.MenuColumnClearFilter: return "Filter aufheben";
                //case GridStringId.MenuColumnBestFitAllColumns: return "Optimale Breite (alle Spalten)";

                // ...  
                default:
                    res = base.GetLocalizedString(id);
                    break;
            }
            return res;
        }
    }
}
