namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("FACTURA")]
    public partial class FACTURA
    {
        public int ID { get; set; }

        [Required]
        [StringLength(80)]
        public string N_FACTURA { get; set; }

        [Required]
        [StringLength(50)]
        public string PROVEEDOR { get; set; }

        [Column(TypeName = "date")]
        public DateTime MES { get; set; }

        public bool PAGADA { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_PAGO { get; set; }

        public Decimal IMPORTE { get; set; }

        public List<FACTURA> Todas()
        {
            var factura = new List<FACTURA>();

            try
            {
                using (var ctx = new crisaless())
                {

                    factura = ctx.FACTURA.ToList();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }


        public FACTURA Obtener(int id)
        {
            var factura = new FACTURA();

            try
            {
                using (var ctx = new crisaless())
                {
                    factura = ctx.FACTURA.Where(x => x.ID == id).SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return factura;
        }


    }
}
