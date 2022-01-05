using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Donem_Projesi.WebUI.Entity
{
    public enum EnumOrderState
    {
        [Display(Name="Onay Bekliyor")]
        Bekliyor,
        [Display(Name="Onaylandı")]
        Onaylandı,
        [Display(Name = "Ürün Kargoya Verildi")]
        Kargolandı,
        [Display(Name = "Ürün Müşteriye Ulaştı")]
        Ulaştı,
        [Display(Name = "Ürün İadesi Alındı")]
        İade
    }
}