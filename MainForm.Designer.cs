namespace GT2EngineSoundEd
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.source_comboBox = new System.Windows.Forms.ComboBox();
            this.dest_comboBox = new System.Windows.Forms.ComboBox();
            this.source_Label = new System.Windows.Forms.Label();
            this.dest_Label = new System.Windows.Forms.Label();
            this.addTask_Button = new System.Windows.Forms.Button();
            this.executeTask_Button = new System.Windows.Forms.Button();
            this.removeTask_Button = new System.Windows.Forms.Button();
            this.tasksQueue_TextBox = new System.Windows.Forms.TextBox();
            this.tasksQueue_Label = new System.Windows.Forms.Label();
            this.errorIndicator_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // source_comboBox
            // 
            this.source_comboBox.FormattingEnabled = true;
            this.source_comboBox.Items.AddRange(new object[] {
            "00001 Toyota Corolla Rally Car",
            "00002 Peugeot 206 Rally Car",
            "00003 Ford Focus Rally Car",
            "00004 Subaru Impreza WRC 97 + Impreza WRC \'99 + Suzuki Cultus Pike\'s Peak",
            "00005 Lexus GS400 + SC400",
            "00006 Toyota Starlet 3door Tuebo S \'82",
            "00007 Toyota Celica WedsSport GT + MR2 Momo Corse GT + BP Apex Kraft Trueno GT + " +
                "Altezza LM",
            "00008 Toyota Supra JGTC",
            "00009 ???",
            "00010 Mazda Demio A-spec",
            "00011 Mercedes-Benz CLK 320 Sport",
            "00012 Mazda 323 Interplay 4door Sedan + GT-X + GT-R",
            "00013 Dodge Viper Oreca + STP Taisan + GTSR + Espace F1",
            "00014 Audi S3 + TT 1.8t quattro",
            "00015 Ciroen Xsara Rally Car",
            "00016 Dodge Concept Car LM",
            "00017 Lancia Stratos",
            "00018 Mazda MX-5",
            "00019 Mazda MX-5 C-spec",
            "00020 Mazda AZ1 A-Spec",
            "00021 ???",
            "00022 Alfa Romeo 155 Touring Car",
            "00023 Fiat Coupe / Fiat Punto",
            "00024 ???",
            "00025 ???",
            "00026 ???",
            "00027 ???",
            "00028 Daihatsu Sirion/Storia X4",
            "00029 Mitsubishi Lancer Evo 5 RS",
            "00030 Lancia Y",
            "00031 Mazda RX7 SA GT Turbo \'83",
            "00032 ???",
            "00033 Mazda 323 GTX + GTR + Interplay",
            "00034 Audi TT LM",
            "00035 Mazda RE Amemiya Matsumoto-Kiyoshi RX7",
            "00036 Lotus Elise GT1",
            "00037 Ford GT90",
            "00038 Lancia Delta S4",
            "00039 Daihatsu Sirion/Storia Rally Car",
            "00040 Nissan 300ZX-GTS",
            "00041 Mazda RX7 A-spec LM",
            "00042 Mitsubishi 3000GT LM",
            "00043 Mazda RX7 GTC LM / RX7 LM",
            "00044 Volkswagen Golf V6",
            "00045 Lotus Esprit GT1",
            "00046 Mitsubishi FTO LM",
            "00047 Nissan Datsun 240ZG",
            "00048 Nissan Skyline P-Ride 280 Type MR",
            "00049 Chevrolet Corvette ZR-1 + Dodge Phaeton",
            "00050 Nissan Skyline R30 Silhouette Formula",
            "00051 Vector M12 LM",
            "00052 Mercedes CLK Race Car",
            "00053 ???",
            "00054 TVR Cerbera LM",
            "00055 Volkswagen New Beetle GT",
            "00056 Venturi Atlantique 600 LM",
            "00057 Honda CR-X DelSol LM + NSX JGTC",
            "00058 Opel/Vauxhall Tigra Ice Race Car + Calibra",
            "00059 Suzuki Escudo + Cusco Subaru Impreza GT300",
            "00060 Nissan Silvia JGTC",
            "00061 Nissan Skyline JGTC + R390 GT1",
            "00062 ???",
            "00063 Saleen SR Widebody",
            "00064 Ford Escort Rally Car",
            "00065 Nissan Micra SR",
            "00066 Nissan Micra Super Turbo \'89",
            "00067 Tommy Kaira ZZ-II",
            "00068 Suzuki Wagon R Aero RS + RT/S + FT + R RR + Cappuccino + Alto Works Limited" +
                " + Alto Work RS/X + Alto Works RS/Z + Kei S + Cervo Mode SR-Four",
            "00069 Toyota GT-One Road Car",
            "00070 Honda Integra Type R 98 + Toyota MR-S Concept Car + Toyota XYR Celica + Toy" +
                "ota Celica ZZT231 SS-II (al packages) + MR2 S Edition ",
            "00071 Nissan Primera \'98",
            "00072 Fiat 500 Sporting + 500R + 600 Sporting",
            "00073 Honda SPOON S2000 + Mazda AZ-1",
            "00074 ???",
            "00075 Mitsubishi Mirage",
            "00076 Toyota Aristo V300",
            "00077 Nissan Primera GT \'90/\'95",
            "00078 Toyota Supra SZ-R",
            "00079 Plymouth Superbird",
            "00080 Toyota TRD 2000GT / Altezza 280T Tom\'s",
            "00081 Honda Mugen Beat",
            "00082 Toyota Tom\'s Angel T01 + Toyota 2000GT",
            "00083 Toyota Supra A70 3.0 Turbo A + 2.5 Twin Turbo R",
            "10003 Toyota AE86 + AE111 \'96/\'98 + TOM\'S T111 + MR2 1600G-Limited Supercharger +" +
                " Corona Exiv",
            "10004 Chevrolet Corvette Grand Sport",
            "(no 10005)",
            "10006 Chevrolet Corvette Coupe",
            "10007 Toyota Starlet 3door Turbo S \'87 + Starlet Glanza V \'96/\'98 + Mazda Demio L" +
                "X G + GL + GL-X \'97/\'99 ",
            "10008 Mitsubishi Eclipse",
            "10009 Nissan 300ZX \'98/\'89/\'94 N/A + Turbo \'89/94",
            "10010 Mitsubishi FTO",
            "10011 Mitsubishi Galant VR-G Touring \'96",
            "10012 Toyota Celica GT-Four ST165/185/205 + MR2 GT-S + Caldina GT-T",
            "10013 Mitsubishi 3000GT \'92/\'95/\'97 + SR \'99",
            "10014 Nissan Skyline GTR R33/R32 + R34 25GT Turbo",
            "10015 Nissan Skyline GTS-R R31 + KPGC10 GT-R + GTS25t Type M R33 + R32 GTS25 Type" +
                " S/GTS4/GTS-T Type M",
            "10016 Mitsubishi Galant VR4 \'96/\'98 + Legnum VR-4 ",
            "10017 Toyota Celica ZZT231 + Honda/Acura Integra Type-R \'95 + Integra SiR-G \'96/\'" +
                "98 + Acura Integra GS-R \'95/\'98",
            "10018 Mitsubishi Lancer Evolution II/III/IV",
            "10019 Subaru SVX + Legacy RS + GT + GT-B",
            "10020 Toyota Celica XX-2800GT + Mark II Tourer V/S + Lexus IS",
            "10021 Honda/Acura NSX",
            "10022 Honda Accord Sedan/Wagon \'96 + Prelude 2.0i \'91/\'96 + Nissan Almera/Pulsar " +
                "Serie VZ-R/N1 + Sunny VZ-R",
            "10023 Mazda 323F/Lantis 2000 Coupe Type R",
            "10024 Mazda MX-5 S-special \'92/93 + Normal \'93/\'89 + V-Special \'90",
            "10025 Mazda RX7 FC GT-X + Infini III + Cosmo Type-S/Type-E + RX-7 A-Spec + Type R" +
                "Z \'96 + Type R \'91 + Type RB \'96 + Touring X \'96",
            "10026 Honda CR-X EF8 + Civic EG SiR/Ferio + CR-X DelSol + Civic Type-R EK \'97 + C" +
                "ivic VTI/SiR EK \'95/\'98",
            "10027 Toyota Chaser Tourer S/V + Soarer GT-T VVT-i + Soarer 2.5 GT-T",
            "10028 Toyota Supra RZ",
            "10029 Toyota Celica GT-R (ST183) + SS-II \'95 + SS-III \'97",
            "10030 Nissan Silvia K\'s 1800cc/2000cc + 180SX Type X + S14 K\'s/200SX + SilEighty " +
                "+ NISMO 270R + Sunny/Pulsar GTi-R",
            "10031 Nissan Silvia Q\'s 1800cc/2000cc + 180SX Type S + S14 Q\'s + Skyline RS-X R30" +
                "",
            "10032 Toyota Aristo 3.0V \'91 + Lexus GS300 + SC300",
            "10034 Dodge Viper RT/10",
            "10035 Subaru Impreza Version II/III/Type-R \'96",
            "20001 Vector M12",
            "20101 Dodge Neon ACR + R/T",
            "20102 Dodge Avenger ES",
            "20103 Dodge Stratus ES",
            "20104 Dodge Viper GTS",
            "20105 Ford Mercury Cougar",
            "20106 Dodge Intrepid ES",
            "20107 Chevrolet Corvette C3 Stingray \'69/\'82",
            "20109 Chevrolet Camaro Z28 302",
            "20111 Chevrolet Camaro Z28 30th Anniversary + Z28 Coupe",
            "20212 Ford Taurus SHO",
            "20301 Shelby Cobra",
            "20302 Shelby Cobra Daytona",
            "20303 Ford GT40 + GT40 Race Car + GT40 Mark III Race Car",
            "20305 Chevrolet Covette 427 Stingray C2",
            "20306 Chevrolet Camaro SS",
            "20308 Plymouth GTX",
            "20310 Ford mustang GT",
            "20311 Ford Mustang SVT Cobra + Vector Wiegert W8",
            "20402 Shelby GT500 + Shelby Series 1",
            "20403 Shelby GT350",
            "20406 Ford Mercury Cougar XR7",
            "20407 Plymouth Muscle Car",
            "20408 Dodge Charger ",
            "20409 Plymouth Hemi Cuda",
            "20410 Dodge Challenger",
            "20501 BMW 328i",
            "20505 Ford RS200 ",
            "20508 Audi A3",
            "20509 Lancia Delta HF",
            "20510 Lancia Delta HF Evoluzione + Collezione",
            "20601 Mini 1.3 + Cooper",
            "20602 Renault Clio 16V + V6 24V",
            "20603 Mercedes-Benz SLK 230 Kompressor",
            "20604 Mercedes-Benz AMG E55 ",
            "20605 Mercedes-Benz A160 Avantgarde",
            "20606 Audi S4",
            "20610 Opel/Vauxhall Corsa Sport + Tigra 1.6i",
            "20701 Opel/Vauxhall Astra SRi",
            "20702 ???",
            "20703 Jaguar XJ Sport 3.2 ",
            "20704 Jaguar XK8",
            "20706 Ford Cougar",
            "20707 Ford Mondeo",
            "20708 Ford KA",
            "20709 Citroen Xsara",
            "20710 Volkswagen Polo 1.4 16V + Golf GTI",
            "20801 Ford Puma ",
            "20802 Jaguar XJR + XKR",
            "20803 Volkswagen Lupo 1.4",
            "20804 Mercedes-Benz CLK 200 Sport",
            "20805 Renault Laguna V6",
            "20806 Volkswagen Golf GTI 1.8T",
            "20807 Aston Martin V8 Vantage / Dodge Concept Car",
            "20808 Lancia Stratos",
            "20809 Aston Martin DB7 Coupe + Volante",
            "20810 TVR Cerbera 4.2 + 4.5 + Speed 6 + Chimaera 4.0 + 4.5 + 5.0",
            "20901 Volkswagen Golf 2.3 V5 + New Beetle GLS",
            "20903 Citroen Saxo",
            "20904 Jaguar XJ220",
            "20905 TVR Griffith",
            "20906 Aston Martin DB6",
            "20907 Venturi Atlantique 400",
            "20908 Jaguar XJR15 Race Car",
            "20910 Venturi 300",
            "21001 Audi A4 2.8 quattro",
            "21002 Opel/Vauxhall Vectra",
            "21003 Renault Megane",
            "21004 Citroen Xantia",
            "21101 Ford Focus 2.0i Zetec + 1.8i Zetec",
            "21102 Lister Storm",
            "21104 Peugeot 106",
            "21106 Peugeot 306 + 406 Sedan",
            "21108 MGF 1.8i VVC",
            "21201 Mitsubishi Lancer Evolution V GSR",
            "21202 Mazda RX7 Type R\'98 + Type RB \'98",
            "21203 Honda Prelude 97 + Mugen Integra Type-R",
            "21204 Subaru Impreza IV/V/VI/22B/GT \'98",
            "21205 Mazda RX7 Type RZ \'97 + Type RB \'97 + Type RS \'97",
            "21206 Nissan Silvia Spec R S15 + S14 K\'s Aero SE Sports Package",
            "21207 Subaru Forester",
            "21208 Subaru Legacy GTB \'99",
            "21209 Peugeot 406 Coupe",
            "21210 Nissan Cube X",
            "21301 Toyota Chaser TRD Sports X30",
            "21302 Mazda RX7 Type RS-R \'97",
            "21303 Mitsubishi 3000GT \'99",
            "21304 Mitsubishi Pajero ",
            "21305 Mazda MX-5 1.8RS NB",
            "21306 Mitsubishi Lancer Evo 6 RS",
            "21307 Mitsubishi Minica pj + Dangan ZZ",
            "21308 Mine\'s Nissan Skyline R34 GT-R + R32.5 + R33",
            "21309 Honda Mugen Civic Ferio + CR-X PRO.2 + CR-X PRO.3 + Mugen Civic Type-R",
            "21310 Mine\'s Mitsubishi Lancer Evolution V + Taevon Trampio FTO",
            "21401 Honda Integra Type-R \'98 Spec + Acura Integra Type-R \'98",
            "21402 Toyota Celica ZZT231 Rally Car",
            "21403 Subaru Vivio + 360 + Pleo RM/RS",
            "21404 Honda SPOON Integra Type-R",
            "21405 Alfa Romeo Spider 2.0TS",
            "21406 Honda Civic Type R \'98",
            "21407 Honda Accord Wagon SiR \'98",
            "21408 Nissan 300ZX Turbo \'98",
            "21409 Mazdaspeed MX-5 C-Spec",
            "21410 Honda Prelude \'98 + Type-S \'96 + Mugen Accord Wagon",
            "21501 Nissan Silvia S15 Spec-S",
            "21503 Honda Accord Wagon 2300VTL 4WD",
            "21504 Honda SPOON Civic Type-R",
            "21505 Mazda MX-5 1.6 S Package NB",
            "21506 Toyota Altezza RS200 + Lexus IS200",
            "21507 Mazdaspeed MX-5 A-spec",
            "21508 Honda Prelude + Accord Type-R",
            "21509 Subaru Legacy Sedan GT RSK",
            "21510 Honda Mugen Prelude Type S",
            "21601 Honda Accord SiR-T \'97/\'98",
            "21602 Honda Z Turbo",
            "21603 Mazda MX-5 1.8VS NB",
            "21604 Honda Mugen Accord SiR-T",
            "21605 Toyota TRD2000GT",
            "21606 Daihatsu Opti Club Sport 4WD/2WD + Aerodown Beex + Midget II D-Type",
            "21607 Daihatsu Move SR-XX 2WD/4WD ",
            "21608 Mazdaspeed MX-5 B-spec",
            "21609 Nissan Skyline R34 GTR V-Spec + NISMO 400R + 400R Preceiding Model + Skylin" +
                "e R33 GT-R 4door Autech NISMO + 4door Autech 40th Anniversary + NISMO GTR-LM",
            "21610 Daihatsu Cuore Normal + TR-XX + Aero Package ",
            "21701 Mazda Demio GL-X Special",
            "21702 Daihatsu Terios Kid Aerodown",
            "21703 Alfa Romeo 156/166 2.5 V6 + 166 3.0 V6",
            "21704 Fiat Coupe + Fiat Punto",
            "21705 Honda Beat + Life T \'97/\'98 + Daihatsu Move Aerodown Custom",
            "21706 Mazda RX7 Type RS \'98",
            "21707 Alfa Romeo 155/156/GTV 2.0TS + 145 2.0 Cloverleaf",
            "21708 Alfa Romeo 3.0 GTV",
            "21709 Toyota Prius",
            "21801 Mitsubishi Lancer EVO 6 GSR",
            "21802 Nissan Skyline R34 GTR",
            "21901 Nissan HKS DRAG 180SX",
            "21903 ???",
            "21904 Nissan HKS DRAG R33 GTR",
            "22001 Lotus Elan S2 \'90",
            "22002 Lotus Elan S2 + S4 Sprint",
            "22101 Lotus Elise Sport 135",
            "22102 Lotus Motorsport Elise",
            "22201 Lotus Elise",
            "22202 Lotus Europa + Esprit V8-SE",
            "22203 Lotus Elise 190",
            "22204 Lotus Elise 111S",
            "22301 Lotus Esprit Sport 350 + V8-GT",
            "22401 TVR Speed 12",
            "22402 TVR Tuscan Speed 6",
            "22501 Mitsubishi Galant VRG \'99",
            "22502 Mitsubishi Legnum ST",
            "22503 Plymouth PT Spyder + Peugeot 206 S16",
            "22504 BMW 528i",
            "22505 Daihatsu Sirion/Storia 2WD/4WD",
            "22506 Honda S2000 GT1",
            "22507 BMW 323ti Compact + 328Ci ",
            "22508 Mazda RX-7 GT-C",
            "22509 BMW 320Ci + 323Ci  ",
            "22510 Nissan Stagea 260RS NISMO + Stagea RS Four V \'97 + 25t RS Four V",
            "22601 Mitsubishi Lancer Evolution V Rally Car",
            "22602 TOM\'S T020",
            "22604 Honda S2000",
            "22605 Toyota TRD3000GT + TOM\'S Supra",
            "22606 Toyota MR2 G-Limited \'98 + MR Spider",
            "22608 Honda Logo TS",
            "22609 Toyota Yaris/Vitz",
            "22610 Nissan Stagea Autech Version 260RS \'97/\'98",
            "22701 Mazda RX7 Cabriolet",
            "22702 Mazda 323F S-Wagon Sport 20",
            "22703 Fiat Barchetta",
            "22704 BMW 740i + 840Ci",
            "22801 RUF Turbo R",
            "22802 RUF BTR 2",
            "22803 RUF CTR2 + CTR2 Sport",
            "22804 RUF BTR Type II",
            "22805 RUF BTR Type I",
            "22806 ??? ",
            "22807 RUF CTR Yellowbird",
            "22808 ???",
            "22809 ??? ",
            "22901 ??? ",
            "22902 RUF RCT",
            "22903 ??? ",
            "22904 Tommy Kaira R34",
            "22905 Tommy Kaira M30 R31",
            "22906 Tommy Kaira ZZ-S + ZZIII + TOM\'S Angel T01 ",
            "22907 Tommy Kaira M30 R32",
            "22908 Tommy Kaira M13",
            "22909 Tommy Kaira R33",
            "23001 Toyota GT-One Race Car \'98/\'99",
            "ene_n AI N/A",
            "ene_t AI Turbo"});
            this.source_comboBox.Location = new System.Drawing.Point(24, 24);
            this.source_comboBox.Name = "source_comboBox";
            this.source_comboBox.Size = new System.Drawing.Size(723, 21);
            this.source_comboBox.TabIndex = 0;
            // 
            // dest_comboBox
            // 
            this.dest_comboBox.FormattingEnabled = true;
            this.dest_comboBox.Items.AddRange(new object[] {
            "00001 Toyota Corolla Rally Car",
            "00002 Peugeot 206 Rally Car",
            "00003 Ford Focus Rally Car",
            "00004 Subaru Impreza WRC 97 + Impreza WRC \'99 + Suzuki Cultus Pike\'s Peak",
            "00005 Lexus GS400 + SC400",
            "00006 Toyota Starlet 3door Tuebo S \'82",
            "00007 Toyota Celica WedsSport GT + MR2 Momo Corse GT + BP Apex Kraft Trueno GT + " +
                "Altezza LM",
            "00008 Toyota Supra JGTC",
            "00009 ???",
            "00010 Mazda Demio A-spec",
            "00011 Mercedes-Benz CLK 320 Sport",
            "00012 Mazda 323 Interplay 4door Sedan + GT-X + GT-R",
            "00013 Dodge Viper Oreca + STP Taisan + GTSR + Espace F1",
            "00014 Audi S3 + TT 1.8t quattro",
            "00015 Ciroen Xsara Rally Car",
            "00016 Dodge Concept Car LM",
            "00017 Lancia Stratos",
            "00018 Mazda MX-5",
            "00019 Mazda MX-5 C-spec",
            "00020 Mazda AZ1 A-Spec",
            "00021 ???",
            "00022 Alfa Romeo 155 Touring Car",
            "00023 Fiat Coupe / Fiat Punto",
            "00024 ???",
            "00025 ???",
            "00026 ???",
            "00027 ???",
            "00028 Daihatsu Sirion/Storia X4",
            "00029 Mitsubishi Lancer Evo 5 RS",
            "00030 Lancia Y",
            "00031 Mazda RX7 SA GT Turbo \'83",
            "00032 ???",
            "00033 Mazda 323 GTX + GTR + Interplay",
            "00034 Audi TT LM",
            "00035 Mazda RE Amemiya Matsumoto-Kiyoshi RX7",
            "00036 Lotus Elise GT1",
            "00037 Ford GT90",
            "00038 Lancia Delta S4",
            "00039 Daihatsu Sirion/Storia Rally Car",
            "00040 Nissan 300ZX-GTS",
            "00041 Mazda RX7 A-spec LM",
            "00042 Mitsubishi 3000GT LM",
            "00043 Mazda RX7 GTC LM / RX7 LM",
            "00044 Volkswagen Golf V6",
            "00045 Lotus Esprit GT1",
            "00046 Mitsubishi FTO LM",
            "00047 Nissan Datsun 240ZG",
            "00048 Nissan Skyline P-Ride 280 Type MR",
            "00049 Chevrolet Corvette ZR-1 + Dodge Phaeton",
            "00050 Nissan Skyline R30 Silhouette Formula",
            "00051 Vector M12 LM",
            "00052 Mercedes CLK Race Car",
            "00053 ???",
            "00054 TVR Cerbera LM",
            "00055 Volkswagen New Beetle GT",
            "00056 Venturi Atlantique 600 LM",
            "00057 Honda CR-X DelSol LM + NSX JGTC",
            "00058 Opel/Vauxhall Tigra Ice Race Car + Calibra",
            "00059 Suzuki Escudo + Cusco Subaru Impreza GT300",
            "00060 Nissan Silvia JGTC",
            "00061 Nissan Skyline JGTC + R390 GT1",
            "00062 ???",
            "00063 Saleen SR Widebody",
            "00064 Ford Escort Rally Car",
            "00065 Nissan Micra SR",
            "00066 Nissan Micra Super Turbo \'89",
            "00067 Tommy Kaira ZZ-II",
            "00068 Suzuki Wagon R Aero RS + RT/S + FT + R RR + Cappuccino + Alto Works Limited" +
                " + Alto Work RS/X + Alto Works RS/Z + Kei S + Cervo Mode SR-Four",
            "00069 Toyota GT-One Road Car",
            "00070 Honda Integra Type R 98 + Toyota MR-S Concept Car + Toyota XYR Celica + Toy" +
                "ota Celica ZZT231 SS-II (al packages) + MR2 S Edition ",
            "00071 Nissan Primera \'98",
            "00072 Fiat 500 Sporting + 500R + 600 Sporting",
            "00073 Honda SPOON S2000 + Mazda AZ-1",
            "00074 ???",
            "00075 Mitsubishi Mirage",
            "00076 Toyota Aristo V300",
            "00077 Nissan Primera GT \'90/\'95",
            "00078 Toyota Supra SZ-R",
            "00079 Plymouth Superbird",
            "00080 Toyota TRD 2000GT / Altezza 280T Tom\'s",
            "00081 Honda Mugen Beat",
            "00082 Toyota Tom\'s Angel T01 + Toyota 2000GT",
            "00083 Toyota Supra A70 3.0 Turbo A + 2.5 Twin Turbo R",
            "10003 Toyota AE86 + AE111 \'96/\'98 + TOM\'S T111 + MR2 1600G-Limited Supercharger +" +
                " Corona Exiv",
            "10004 Chevrolet Corvette Grand Sport",
            "(no 10005)",
            "10006 Chevrolet Corvette Coupe",
            "10007 Toyota Starlet 3door Turbo S \'87 + Starlet Glanza V \'96/\'98 + Mazda Demio L" +
                "X G + GL + GL-X \'97/\'99 ",
            "10008 Mitsubishi Eclipse",
            "10009 Nissan 300ZX \'98/\'89/\'94 N/A + Turbo \'89/94",
            "10010 Mitsubishi FTO",
            "10011 Mitsubishi Galant VR-G Touring \'96",
            "10012 Toyota Celica GT-Four ST165/185/205 + MR2 GT-S + Caldina GT-T",
            "10013 Mitsubishi 3000GT \'92/\'95/\'97 + SR \'99",
            "10014 Nissan Skyline GTR R33/R32 + R34 25GT Turbo",
            "10015 Nissan Skyline GTS-R R31 + KPGC10 GT-R + GTS25t Type M R33 + R32 GTS25 Type" +
                " S/GTS4/GTS-T Type M",
            "10016 Mitsubishi Galant VR4 \'96/\'98 + Legnum VR-4 ",
            "10017 Toyota Celica ZZT231 + Honda/Acura Integra Type-R \'95 + Integra SiR-G \'96/\'" +
                "98 + Acura Integra GS-R \'95/\'98",
            "10018 Mitsubishi Lancer Evolution II/III/IV",
            "10019 Subaru SVX + Legacy RS + GT + GT-B",
            "10020 Toyota Celica XX-2800GT + Mark II Tourer V/S + Lexus IS",
            "10021 Honda/Acura NSX",
            "10022 Honda Accord Sedan/Wagon \'96 + Prelude 2.0i \'91/\'96 + Nissan Almera/Pulsar " +
                "Serie VZ-R/N1 + Sunny VZ-R",
            "10023 Mazda 323F/Lantis 2000 Coupe Type R",
            "10024 Mazda MX-5 S-special \'92/93 + Normal \'93/\'89 + V-Special \'90",
            "10025 Mazda RX7 FC GT-X + Infini III + Cosmo Type-S/Type-E + RX-7 A-Spec + Type R" +
                "Z \'96 + Type R \'91 + Type RB \'96 + Touring X \'96",
            "10026 Honda CR-X EF8 + Civic EG SiR/Ferio + CR-X DelSol + Civic Type-R EK \'97 + C" +
                "ivic VTI/SiR EK \'95/\'98",
            "10027 Toyota Chaser Tourer S/V + Soarer GT-T VVT-i + Soarer 2.5 GT-T",
            "10028 Toyota Supra RZ",
            "10029 Toyota Celica GT-R (ST183) + SS-II \'95 + SS-III \'97",
            "10030 Nissan Silvia K\'s 1800cc/2000cc + 180SX Type X + S14 K\'s/200SX + SilEighty " +
                "+ NISMO 270R + Sunny/Pulsar GTi-R",
            "10031 Nissan Silvia Q\'s 1800cc/2000cc + 180SX Type S + S14 Q\'s + Skyline RS-X R30" +
                "",
            "10032 Toyota Aristo 3.0V \'91 + Lexus GS300 + SC300",
            "10034 Dodge Viper RT/10",
            "10035 Subaru Impreza Version II/III/Type-R \'96",
            "20001 Vector M12",
            "20101 Dodge Neon ACR + R/T",
            "20102 Dodge Avenger ES",
            "20103 Dodge Stratus ES",
            "20104 Dodge Viper GTS",
            "20105 Ford Mercury Cougar",
            "20106 Dodge Intrepid ES",
            "20107 Chevrolet Corvette C3 Stingray \'69/\'82",
            "20109 Chevrolet Camaro Z28 302",
            "20111 Chevrolet Camaro Z28 30th Anniversary + Z28 Coupe",
            "20212 Ford Taurus SHO",
            "20301 Shelby Cobra",
            "20302 Shelby Cobra Daytona",
            "20303 Ford GT40 + GT40 Race Car + GT40 Mark III Race Car",
            "20305 Chevrolet Covette 427 Stingray C2",
            "20306 Chevrolet Camaro SS",
            "20308 Plymouth GTX",
            "20310 Ford mustang GT",
            "20311 Ford Mustang SVT Cobra + Vector Wiegert W8",
            "20402 Shelby GT500 + Shelby Series 1",
            "20403 Shelby GT350",
            "20406 Ford Mercury Cougar XR7",
            "20407 Plymouth Muscle Car",
            "20408 Dodge Charger ",
            "20409 Plymouth Hemi Cuda",
            "20410 Dodge Challenger",
            "20501 BMW 328i",
            "20505 Ford RS200 ",
            "20508 Audi A3",
            "20509 Lancia Delta HF",
            "20510 Lancia Delta HF Evoluzione + Collezione",
            "20601 Mini 1.3 + Cooper",
            "20602 Renault Clio 16V + V6 24V",
            "20603 Mercedes-Benz SLK 230 Kompressor",
            "20604 Mercedes-Benz AMG E55 ",
            "20605 Mercedes-Benz A160 Avantgarde",
            "20606 Audi S4",
            "20610 Opel/Vauxhall Corsa Sport + Tigra 1.6i",
            "20701 Opel/Vauxhall Astra SRi",
            "20702 ???",
            "20703 Jaguar XJ Sport 3.2 ",
            "20704 Jaguar XK8",
            "20706 Ford Cougar",
            "20707 Ford Mondeo",
            "20708 Ford KA",
            "20709 Citroen Xsara",
            "20710 Volkswagen Polo 1.4 16V + Golf GTI",
            "20801 Ford Puma ",
            "20802 Jaguar XJR + XKR",
            "20803 Volkswagen Lupo 1.4",
            "20804 Mercedes-Benz CLK 200 Sport",
            "20805 Renault Laguna V6",
            "20806 Volkswagen Golf GTI 1.8T",
            "20807 Aston Martin V8 Vantage / Dodge Concept Car",
            "20808 Lancia Stratos",
            "20809 Aston Martin DB7 Coupe + Volante",
            "20810 TVR Cerbera 4.2 + 4.5 + Speed 6 + Chimaera 4.0 + 4.5 + 5.0",
            "20901 Volkswagen Golf 2.3 V5 + New Beetle GLS",
            "20903 Citroen Saxo",
            "20904 Jaguar XJ220",
            "20905 TVR Griffith",
            "20906 Aston Martin DB6",
            "20907 Venturi Atlantique 400",
            "20908 Jaguar XJR15 Race Car",
            "20910 Venturi 300",
            "21001 Audi A4 2.8 quattro",
            "21002 Opel/Vauxhall Vectra",
            "21003 Renault Megane",
            "21004 Citroen Xantia",
            "21101 Ford Focus 2.0i Zetec + 1.8i Zetec",
            "21102 Lister Storm",
            "21104 Peugeot 106",
            "21106 Peugeot 306 + 406 Sedan",
            "21108 MGF 1.8i VVC",
            "21201 Mitsubishi Lancer Evolution V GSR",
            "21202 Mazda RX7 Type R\'98 + Type RB \'98",
            "21203 Honda Prelude 97 + Mugen Integra Type-R",
            "21204 Subaru Impreza IV/V/VI/22B/GT \'98",
            "21205 Mazda RX7 Type RZ \'97 + Type RB \'97 + Type RS \'97",
            "21206 Nissan Silvia Spec R S15 + S14 K\'s Aero SE Sports Package",
            "21207 Subaru Forester",
            "21208 Subaru Legacy GTB \'99",
            "21209 Peugeot 406 Coupe",
            "21210 Nissan Cube X",
            "21301 Toyota Chaser TRD Sports X30",
            "21302 Mazda RX7 Type RS-R \'97",
            "21303 Mitsubishi 3000GT \'99",
            "21304 Mitsubishi Pajero ",
            "21305 Mazda MX-5 1.8RS NB",
            "21306 Mitsubishi Lancer Evo 6 RS",
            "21307 Mitsubishi Minica pj + Dangan ZZ",
            "21308 Mine\'s Nissan Skyline R34 GT-R + R32.5 + R33",
            "21309 Honda Mugen Civic Ferio + CR-X PRO.2 + CR-X PRO.3 + Mugen Civic Type-R",
            "21310 Mine\'s Mitsubishi Lancer Evolution V + Taevon Trampio FTO",
            "21401 Honda Integra Type-R \'98 Spec + Acura Integra Type-R \'98",
            "21402 Toyota Celica ZZT231 Rally Car",
            "21403 Subaru Vivio + 360 + Pleo RM/RS",
            "21404 Honda SPOON Integra Type-R",
            "21405 Alfa Romeo Spider 2.0TS",
            "21406 Honda Civic Type R \'98",
            "21407 Honda Accord Wagon SiR \'98",
            "21408 Nissan 300ZX Turbo \'98",
            "21409 Mazdaspeed MX-5 C-Spec",
            "21410 Honda Prelude \'98 + Type-S \'96 + Mugen Accord Wagon",
            "21501 Nissan Silvia S15 Spec-S",
            "21503 Honda Accord Wagon 2300VTL 4WD",
            "21504 Honda SPOON Civic Type-R",
            "21505 Mazda MX-5 1.6 S Package NB",
            "21506 Toyota Altezza RS200 + Lexus IS200",
            "21507 Mazdaspeed MX-5 A-spec",
            "21508 Honda Prelude + Accord Type-R",
            "21509 Subaru Legacy Sedan GT RSK",
            "21510 Honda Mugen Prelude Type S",
            "21601 Honda Accord SiR-T \'97/\'98",
            "21602 Honda Z Turbo",
            "21603 Mazda MX-5 1.8VS NB",
            "21604 Honda Mugen Accord SiR-T",
            "21605 Toyota TRD2000GT",
            "21606 Daihatsu Opti Club Sport 4WD/2WD + Aerodown Beex + Midget II D-Type",
            "21607 Daihatsu Move SR-XX 2WD/4WD ",
            "21608 Mazdaspeed MX-5 B-spec",
            "21609 Nissan Skyline R34 GTR V-Spec + NISMO 400R + 400R Preceiding Model + Skylin" +
                "e R33 GT-R 4door Autech NISMO + 4door Autech 40th Anniversary + NISMO GTR-LM",
            "21610 Daihatsu Cuore Normal + TR-XX + Aero Package ",
            "21701 Mazda Demio GL-X Special",
            "21702 Daihatsu Terios Kid Aerodown",
            "21703 Alfa Romeo 156/166 2.5 V6 + 166 3.0 V6",
            "21704 Fiat Coupe + Fiat Punto",
            "21705 Honda Beat + Life T \'97/\'98 + Daihatsu Move Aerodown Custom",
            "21706 Mazda RX7 Type RS \'98",
            "21707 Alfa Romeo 155/156/GTV 2.0TS + 145 2.0 Cloverleaf",
            "21708 Alfa Romeo 3.0 GTV",
            "21709 Toyota Prius",
            "21801 Mitsubishi Lancer EVO 6 GSR",
            "21802 Nissan Skyline R34 GTR",
            "21901 Nissan HKS DRAG 180SX",
            "21903 ???",
            "21904 Nissan HKS DRAG R33 GTR",
            "22001 Lotus Elan S2 \'90",
            "22002 Lotus Elan S2 + S4 Sprint",
            "22101 Lotus Elise Sport 135",
            "22102 Lotus Motorsport Elise",
            "22201 Lotus Elise",
            "22202 Lotus Europa + Esprit V8-SE",
            "22203 Lotus Elise 190",
            "22204 Lotus Elise 111S",
            "22301 Lotus Esprit Sport 350 + V8-GT",
            "22401 TVR Speed 12",
            "22402 TVR Tuscan Speed 6",
            "22501 Mitsubishi Galant VRG \'99",
            "22502 Mitsubishi Legnum ST",
            "22503 Plymouth PT Spyder + Peugeot 206 S16",
            "22504 BMW 528i",
            "22505 Daihatsu Sirion/Storia 2WD/4WD",
            "22506 Honda S2000 GT1",
            "22507 BMW 323ti Compact + 328Ci ",
            "22508 Mazda RX-7 GT-C",
            "22509 BMW 320Ci + 323Ci  ",
            "22510 Nissan Stagea 260RS NISMO + Stagea RS Four V \'97 + 25t RS Four V",
            "22601 Mitsubishi Lancer Evolution V Rally Car",
            "22602 TOM\'S T020",
            "22604 Honda S2000",
            "22605 Toyota TRD3000GT + TOM\'S Supra",
            "22606 Toyota MR2 G-Limited \'98 + MR Spider",
            "22608 Honda Logo TS",
            "22609 Toyota Yaris/Vitz",
            "22610 Nissan Stagea Autech Version 260RS \'97/\'98",
            "22701 Mazda RX7 Cabriolet",
            "22702 Mazda 323F S-Wagon Sport 20",
            "22703 Fiat Barchetta",
            "22704 BMW 740i + 840Ci",
            "22801 RUF Turbo R",
            "22802 RUF BTR 2",
            "22803 RUF CTR2 + CTR2 Sport",
            "22804 RUF BTR Type II",
            "22805 RUF BTR Type I",
            "22806 ??? ",
            "22807 RUF CTR Yellowbird",
            "22808 ???",
            "22809 ??? ",
            "22901 ??? ",
            "22902 RUF RCT",
            "22903 ??? ",
            "22904 Tommy Kaira R34",
            "22905 Tommy Kaira M30 R31",
            "22906 Tommy Kaira ZZ-S + ZZIII + TOM\'S Angel T01 ",
            "22907 Tommy Kaira M30 R32",
            "22908 Tommy Kaira M13",
            "22909 Tommy Kaira R33",
            "23001 Toyota GT-One Race Car \'98/\'99",
            "ene_n AI N/A",
            "ene_t AI Turbo"});
            this.dest_comboBox.Location = new System.Drawing.Point(24, 84);
            this.dest_comboBox.Name = "dest_comboBox";
            this.dest_comboBox.Size = new System.Drawing.Size(723, 21);
            this.dest_comboBox.TabIndex = 1;
            // 
            // source_Label
            // 
            this.source_Label.AutoSize = true;
            this.source_Label.Location = new System.Drawing.Point(340, 8);
            this.source_Label.Name = "source_Label";
            this.source_Label.Size = new System.Drawing.Size(111, 13);
            this.source_Label.TabIndex = 2;
            this.source_Label.Text = "Source Engine Sound";
            // 
            // dest_Label
            // 
            this.dest_Label.AutoSize = true;
            this.dest_Label.Location = new System.Drawing.Point(351, 68);
            this.dest_Label.Name = "dest_Label";
            this.dest_Label.Size = new System.Drawing.Size(90, 13);
            this.dest_Label.TabIndex = 3;
            this.dest_Label.Text = "Destination Car(s)";
            // 
            // addTask_Button
            // 
            this.addTask_Button.Location = new System.Drawing.Point(591, 281);
            this.addTask_Button.Name = "addTask_Button";
            this.addTask_Button.Size = new System.Drawing.Size(75, 23);
            this.addTask_Button.TabIndex = 4;
            this.addTask_Button.Text = "Add Task";
            this.addTask_Button.UseVisualStyleBackColor = true;
            this.addTask_Button.Click += new System.EventHandler(this.addTask_ButtonClick);
            // 
            // executeTask_Button
            // 
            this.executeTask_Button.Location = new System.Drawing.Point(672, 281);
            this.executeTask_Button.Name = "executeTask_Button";
            this.executeTask_Button.Size = new System.Drawing.Size(75, 23);
            this.executeTask_Button.TabIndex = 5;
            this.executeTask_Button.Text = "Execute All";
            this.executeTask_Button.UseVisualStyleBackColor = true;
            this.executeTask_Button.Click += new System.EventHandler(this.executeTask_ButtonClick);
            // 
            // removeTask_Button
            // 
            this.removeTask_Button.Location = new System.Drawing.Point(495, 281);
            this.removeTask_Button.Name = "removeTask_Button";
            this.removeTask_Button.Size = new System.Drawing.Size(90, 23);
            this.removeTask_Button.TabIndex = 6;
            this.removeTask_Button.Text = "Remove Task";
            this.removeTask_Button.UseVisualStyleBackColor = true;
            this.removeTask_Button.Click += new System.EventHandler(this.removeTask_ButtonClick);
            // 
            // tasksQueue_TextBox
            // 
            this.tasksQueue_TextBox.Location = new System.Drawing.Point(24, 131);
            this.tasksQueue_TextBox.Multiline = true;
            this.tasksQueue_TextBox.Name = "tasksQueue_TextBox";
            this.tasksQueue_TextBox.Size = new System.Drawing.Size(723, 144);
            this.tasksQueue_TextBox.TabIndex = 7;
            this.tasksQueue_TextBox.WordWrap = false;
            // 
            // tasksQueue_Label
            // 
            this.tasksQueue_Label.AutoSize = true;
            this.tasksQueue_Label.Location = new System.Drawing.Point(360, 115);
            this.tasksQueue_Label.Name = "tasksQueue_Label";
            this.tasksQueue_Label.Size = new System.Drawing.Size(71, 13);
            this.tasksQueue_Label.TabIndex = 8;
            this.tasksQueue_Label.Text = "Tasks Queue";
            // 
            // errorIndicator_Label
            // 
            this.errorIndicator_Label.AutoSize = true;
            this.errorIndicator_Label.Location = new System.Drawing.Point(30, 291);
            this.errorIndicator_Label.Name = "errorIndicator_Label";
            this.errorIndicator_Label.Size = new System.Drawing.Size(38, 13);
            this.errorIndicator_Label.TabIndex = 9;
            this.errorIndicator_Label.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 316);
            this.Controls.Add(this.errorIndicator_Label);
            this.Controls.Add(this.tasksQueue_Label);
            this.Controls.Add(this.tasksQueue_TextBox);
            this.Controls.Add(this.removeTask_Button);
            this.Controls.Add(this.executeTask_Button);
            this.Controls.Add(this.addTask_Button);
            this.Controls.Add(this.dest_Label);
            this.Controls.Add(this.source_Label);
            this.Controls.Add(this.dest_comboBox);
            this.Controls.Add(this.source_comboBox);
            this.Name = "MainForm";
            this.Text = "GT2 Engine Sound Editor v0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox source_comboBox;
        private System.Windows.Forms.ComboBox dest_comboBox;
        private System.Windows.Forms.Label source_Label;
        private System.Windows.Forms.Label dest_Label;
        private System.Windows.Forms.Button addTask_Button;
        private System.Windows.Forms.Button executeTask_Button;
        private System.Windows.Forms.Button removeTask_Button;
        private System.Windows.Forms.TextBox tasksQueue_TextBox;
        private System.Windows.Forms.Label tasksQueue_Label;
        private System.Windows.Forms.Label errorIndicator_Label;
    }
}

