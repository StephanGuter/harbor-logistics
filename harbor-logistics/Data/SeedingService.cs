using harbor_logistics.Models;
using harbor_logistics.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace harbor_logistics.Data
{
    public class SeedingService
    {
        private HarborLogisticsContext _context { get; set; }

        public SeedingService(HarborLogisticsContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!(_context.Customer.Any() || _context.Container.Any() || _context.Movement.Any()))
            {
                Customer c1 = new Customer(1, "24.664.515/0001-54", "Acme Terminals", "+551112345678", new DateTime(2018, 05, 20));
                Customer c2 = new Customer(2, "70.849.415/0001-10", "Bikegill", "+551223456781", new DateTime(2018, 07, 02));
                Customer c3 = new Customer(3, "71.661.654/0001-04", "Oceania Shipping", "+551334567812", new DateTime(2018, 07, 22));
                Customer c4 = new Customer(4, "75.860.998/0001-01", "OrganicLogitec", "+551445678123", new DateTime(2019, 01, 17));
                Customer c5 = new Customer(5, "40.015.328/0001-04", "Wilson Daughters", "+551556781234", new DateTime(2020, 03, 07));
                Customer c6 = new Customer(6, "60.261.256/0001-84", "Maersky Curve", "+551667812345", new DateTime(2020, 11, 12));

                _context.Customer.AddRange(c1, c2, c3, c4, c5, c6);

                Container co01 = new Container(1, "TEST1234567", ContainerStatus.Vazio, ContainerCategory.Exportacao, ContainerType.S20, c1);
                Container co02 = new Container(2, "ABCD1234567", ContainerStatus.Vazio, ContainerCategory.Importacao, ContainerType.S40, c1);
                Container co03 = new Container(3, "BCDE2345678", ContainerStatus.Cheio, ContainerCategory.Importacao, ContainerType.S40, c1);
                Container co04 = new Container(4, "CDEF3456789", ContainerStatus.Cheio, ContainerCategory.Exportacao, ContainerType.S40, c1);
                Container co05 = new Container(5, "DEFG4567891", ContainerStatus.Cheio, ContainerCategory.Exportacao, ContainerType.S20, c1);
                Container co06 = new Container(6, "EFGH5678912", ContainerStatus.Vazio, ContainerCategory.Exportacao, ContainerType.S20, c2);
                Container co07 = new Container(7, "FGHI6789123", ContainerStatus.Vazio, ContainerCategory.Exportacao, ContainerType.S40, c2);
                Container co08 = new Container(8, "GHIJ7891234", ContainerStatus.Cheio, ContainerCategory.Importacao, ContainerType.S40, c2);
                Container co09 = new Container(9, "HIJK8912345", ContainerStatus.Vazio, ContainerCategory.Exportacao, ContainerType.S20, c3);
                Container co10 = new Container(10, "IJKL9123456", ContainerStatus.Cheio, ContainerCategory.Exportacao, ContainerType.S40, c3);
                Container co11 = new Container(11, "JKLM1234567", ContainerStatus.Vazio, ContainerCategory.Importacao, ContainerType.S40, c3);
                Container co12 = new Container(12, "KLMN2345678", ContainerStatus.Vazio, ContainerCategory.Importacao, ContainerType.S20, c3);
                Container co13 = new Container(13, "LMNO3456789", ContainerStatus.Vazio, ContainerCategory.Importacao, ContainerType.S40, c3);
                Container co14 = new Container(14, "MNOP4567891", ContainerStatus.Cheio, ContainerCategory.Importacao, ContainerType.S40, c3);
                Container co15 = new Container(15, "NOPQ5678912", ContainerStatus.Cheio, ContainerCategory.Importacao, ContainerType.S40, c3);
                Container co16 = new Container(16, "OPQR6789123", ContainerStatus.Vazio, ContainerCategory.Exportacao, ContainerType.S40, c4);
                Container co17 = new Container(17, "PQRS7891234", ContainerStatus.Vazio, ContainerCategory.Importacao, ContainerType.S40, c5);
                Container co18 = new Container(18, "QRST8912345", ContainerStatus.Vazio, ContainerCategory.Exportacao, ContainerType.S20, c5);
                Container co19 = new Container(19, "RSTU9123456", ContainerStatus.Cheio, ContainerCategory.Importacao, ContainerType.S40, c6);
                Container co20 = new Container(20, "STUV1234567", ContainerStatus.Vazio, ContainerCategory.Importacao, ContainerType.S40, c6);

                _context.Container.AddRange(
                    co01,
                    co02,
                    co03,
                    co04,
                    co05,
                    co06,
                    co07,
                    co08,
                    co09,
                    co10,
                    co11,
                    co12,
                    co13,
                    co14,
                    co15,
                    co16,
                    co17,
                    co18,
                    co19,
                    co20
                );

                Movement m01 = new Movement(1, new DateTime(2018, 05, 21, 07, 30, 00), new DateTime(2018, 05, 22, 17, 30, 00), MovementType.Embarque, co01);
                Movement m02 = new Movement(2, new DateTime(2018, 05, 22, 07, 30, 00), new DateTime(2018, 05, 23, 17, 30, 00), MovementType.Pesagem, co01);
                Movement m03 = new Movement(3, new DateTime(2018, 05, 23, 07, 30, 00), new DateTime(2018, 05, 24, 17, 30, 00), MovementType.GateIn, co01);
                Movement m04 = new Movement(4, new DateTime(2018, 05, 22, 07, 30, 00), new DateTime(2018, 05, 24, 17, 30, 00), MovementType.Pilha, co02);
                Movement m05 = new Movement(5, new DateTime(2018, 05, 22, 07, 30, 00), new DateTime(2018, 05, 23, 17, 30, 00), MovementType.Posicionamento, co03);
                Movement m06 = new Movement(6, new DateTime(2018, 05, 24, 07, 30, 00), new DateTime(2018, 05, 25, 17, 30, 00), MovementType.Embarque, co03);
                Movement m07 = new Movement(7, new DateTime(2018, 06, 01, 07, 30, 00), new DateTime(2018, 06, 03, 17, 30, 00), MovementType.Embarque, co04);
                Movement m08 = new Movement(8, new DateTime(2018, 06, 04, 07, 30, 00), new DateTime(2018, 06, 05, 17, 30, 00), MovementType.Pesagem, co04);
                Movement m09 = new Movement(9, new DateTime(2018, 06, 05, 07, 30, 00), new DateTime(2018, 06, 05, 17, 30, 00), MovementType.Posicionamento, co04);
                Movement m10 = new Movement(10, new DateTime(2018, 08, 03, 07, 30, 00), new DateTime(2018, 08, 04, 17, 30, 00), MovementType.Embarque, co05);
                Movement m11 = new Movement(11, new DateTime(2018, 08, 04, 07, 30, 00), new DateTime(2018, 08, 06, 17, 30, 00), MovementType.Descarga, co05);
                Movement m12 = new Movement(12, new DateTime(2018, 07, 03, 07, 30, 00), new DateTime(2018, 07, 06, 17, 30, 00), MovementType.Embarque, co06);
                Movement m13 = new Movement(13, new DateTime(2018, 07, 15, 07, 30, 00), new DateTime(2018, 07, 16, 17, 30, 00), MovementType.Embarque, co07);
                Movement m14 = new Movement(14, new DateTime(2018, 07, 18, 07, 30, 00), new DateTime(2018, 07, 19, 17, 30, 00), MovementType.Descarga, co07);
                Movement m15 = new Movement(15, new DateTime(2018, 07, 04, 07, 30, 00), new DateTime(2018, 07, 05, 17, 30, 00), MovementType.Embarque, co08);
                Movement m16 = new Movement(16, new DateTime(2018, 07, 06, 07, 30, 00), new DateTime(2018, 07, 06, 17, 30, 00), MovementType.Descarga, co08);
                Movement m17 = new Movement(17, new DateTime(2018, 07, 23, 07, 30, 00), new DateTime(2018, 07, 23, 17, 30, 00), MovementType.Embarque, co09);
                Movement m18 = new Movement(18, new DateTime(2018, 07, 24, 07, 30, 00), new DateTime(2018, 07, 25, 17, 30, 00), MovementType.Pesagem, co09);
                Movement m19 = new Movement(19, new DateTime(2018, 07, 27, 07, 30, 00), new DateTime(2018, 07, 28, 17, 30, 00), MovementType.Descarga, co09);
                Movement m20 = new Movement(20, new DateTime(2018, 08, 12, 07, 30, 00), new DateTime(2018, 08, 16, 17, 30, 00), MovementType.Embarque, co10);
                Movement m21 = new Movement(21, new DateTime(2018, 12, 14, 07, 30, 00), MovementType.Embarque, co11);
                Movement m22 = new Movement(22, new DateTime(2019, 03, 26, 07, 30, 00), new DateTime(2018, 03, 30, 17, 30, 00), MovementType.Embarque, co12);
                Movement m23 = new Movement(23, new DateTime(2019, 04, 01, 07, 30, 00), new DateTime(2019, 05, 01, 17, 30, 00), MovementType.Descarga, co12);
                Movement m24 = new Movement(24, new DateTime(2019, 09, 21, 07, 30, 00), new DateTime(2019, 10, 05, 17, 30, 00), MovementType.Embarque, co13);
                Movement m25 = new Movement(25, new DateTime(2018, 09, 06, 07, 30, 00), new DateTime(2018, 09, 10, 17, 30, 00), MovementType.Pesagem, co13);
                Movement m26 = new Movement(26, new DateTime(2018, 09, 10, 07, 30, 00), new DateTime(2018, 09, 10, 17, 30, 00), MovementType.Descarga, co13);
                Movement m27 = new Movement(27, new DateTime(2020, 02, 02, 07, 30, 00), new DateTime(2020, 02, 22, 17, 30, 00), MovementType.Embarque, co14);
                Movement m28 = new Movement(28, new DateTime(2020, 02, 22, 07, 30, 00), new DateTime(2020, 02, 24, 17, 30, 00), MovementType.Descarga, co14);
                Movement m29 = new Movement(29, new DateTime(2021, 03, 09, 07, 30, 00), new DateTime(2021, 03, 12, 17, 30, 00), MovementType.Posicionamento, co15);
                Movement m30 = new Movement(30, new DateTime(2019, 01, 18, 07, 30, 00), new DateTime(2019, 01, 20, 17, 30, 00), MovementType.GateIn, co16);
                Movement m31 = new Movement(31, new DateTime(2019, 01, 21, 07, 30, 00), new DateTime(2019, 01, 27, 17, 30, 00), MovementType.Scanner, co16);
                Movement m32 = new Movement(32, new DateTime(2019, 01, 28, 07, 30, 00), new DateTime(2019, 02, 11, 17, 30, 00), MovementType.GateOut, co16);
                Movement m33 = new Movement(33, new DateTime(2020, 04, 21, 07, 30, 00), new DateTime(2020, 05, 02, 17, 30, 00), MovementType.GateIn, co17);
                Movement m34 = new Movement(34, new DateTime(2020, 05, 02, 07, 30, 00), new DateTime(2020, 05, 19, 17, 30, 00), MovementType.GateOut, co17);
                Movement m35 = new Movement(35, new DateTime(2020, 12, 04, 07, 30, 00), MovementType.Pilha, co18);
                Movement m36 = new Movement(36, new DateTime(2020, 11, 14, 07, 30, 00), new DateTime(2020, 11, 15, 17, 30, 00), MovementType.Pilha, co19);
                Movement m37 = new Movement(37, new DateTime(2020, 11, 15, 07, 30, 00), new DateTime(2020, 11, 21, 17, 30, 00), MovementType.Embarque, co19);
                Movement m38 = new Movement(38, new DateTime(2021, 04, 13, 07, 30, 00), MovementType.Pesagem, co19);
                Movement m39 = new Movement(39, new DateTime(2021, 01, 16, 07, 30, 00), new DateTime(2021, 01, 27, 17, 30, 00), MovementType.Embarque, co20);
                Movement m40 = new Movement(40, new DateTime(2021, 05, 24, 07, 30, 00), MovementType.Descarga, co20);

                _context.Movement.AddRange(
                    m01,
                    m02,
                    m03,
                    m04,
                    m05,
                    m06,
                    m07,
                    m08,
                    m09,
                    m10,
                    m11,
                    m12,
                    m13,
                    m14,
                    m15,
                    m16,
                    m17,
                    m18,
                    m19,
                    m20,
                    m21,
                    m22,
                    m23,
                    m24,
                    m25,
                    m26,
                    m27,
                    m28,
                    m29,
                    m30,
                    m31,
                    m32,
                    m33,
                    m34,
                    m35,
                    m36,
                    m37,
                    m38,
                    m39,
                    m40
                );

                _context.SaveChanges();
            }
        }
    }
}
