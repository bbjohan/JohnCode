using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JohnCode
{
    public partial class JohnCode : Form
    {
        static int stackd = 1000;
        int AH = 0, AL = 0, BH = 0, BL = 0, CH = 0, CL = 0, DH = 0, DL = 0;
        int CS = 0, IP = 0, SS = 0, SP = 0, BP = 0, SI = 0, DI = 0, DS = 0, ES = 0;
        Boolean click=false, sbs=false;
        Int32[,] stack = new Int32[2, stackd];
        string[,] etichette = new string[2, 10];
        string confronto = "";
        int i = 0,s=0;

        public JohnCode()
        {
            InitializeComponent();
        }  

        private void avanti_Click(object sender, EventArgs e)
        {
            click = true;
            MessageBox.Show("Ciao");
        }
        private void stepbystep_CheckedChanged(object sender, EventArgs e)
        {
            if (stepbystep.Checked)
            {
                avanti.Enabled = true;
                sbs = true;
            }
        }
        public string NomeFile = "";
        public string TestoIniziale = "";
        private void Salva()
        {
            SalvaFile.ShowDialog();
            try
            {
                if (SalvaFile.FileName != null)
                {
                    System.IO.File.WriteAllText(SalvaFile.FileName, AreaTesto.Text);
                    NomeFile = SalvaFile.FileName;
                }
            }
            catch { }
        }
        void Controllo()
        {
            if(AH>255)
            {
                AH = AH-256;
            }
            if (AL > 255)
            {
                AL = AL-256;
            }
            if (BH > 255)
            {
                BH = BH-256;
            }
            if (BL > 255)
            {
                BL = BL - 256;
            }
            if (CH > 255)
            {
                CH = CH - 256;
            }
            if (CL > 255)
            {
                CL = CL - 256;
            }
            if (DH > 255)
            {
                DH = DH - 256;
            }
            if (DL > 255)
            {
                DL   = DL - 256;
            }
            AHB.Text = (Convert.ToString(AH));
            ALB.Text = (Convert.ToString(AL));
            BHB.Text = (Convert.ToString(BH));
            BLB.Text = (Convert.ToString(BL));
            CHB.Text = (Convert.ToString(CH));
            CLB.Text = (Convert.ToString(CL));
            DHB.Text = (Convert.ToString(DH));
            DLB.Text = (Convert.ToString(DL));
        }
        private int var(String variabile)
        {
                if (variabile == "AH")
                {
                    return AH;
                }
                else if (variabile == "AL")
                {
                    return AL;
                }
                else if (variabile == "BH")
                {
                    return BH;
                }
                else if (variabile == "BL")
                {
                    return BL;
                }
                else if (variabile == "CH")
                {
                    return CH;
                }
                else if (variabile == "CL")
                {
                    return CL;
                }
                else if (variabile == "DH")
                {
                    return DH;
                }
                else if (variabile == "DL")
                {
                    return DL;
                }
                else
                {
                    return 0;
                }         
        }

        private void StackUpdate()
        {
            StackView.Clear();
            for (int r = 0; r < stackd; r++)
            {
                StackView.Items.Add("[" + stack[0,r].ToString("x4") + "] " +Convert.ToString(stack[1, r]));
            }
        }
        private void azzerastack()
        {
            for (int r = 0; r < stackd; r++)
            {
                stack[0, r] = Convert.ToInt32(r);
                stack[1, r] = 0;
            }
        }

        private void AreaTesto_TextChanged(object sender, EventArgs e)
        {
            nrighe.Text = AreaTesto.Lines.Count().ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            titolo("Nuovo file");
            avanti.Enabled=false;
            azzerastack();
        }
        private void titolo(string TitoloFile)
        {
            this.Text = "JohnCode - " + TitoloFile;
        }
        private void ControlloTesto()
        {
            if (AreaTesto.Text != TestoIniziale)
            {
                DialogResult risposta = MessageBox.Show("Vuoi salvare?", "Salva", MessageBoxButtons.YesNo);
                try
                {
                    if (risposta == DialogResult.Yes)
                    {
                        TestoIniziale = "";
                        Salva();
                    }
                    if (risposta == DialogResult.No)
                    {
                        TestoIniziale = "";
                    }
                }
                catch { }
            }
        }
        private void nuovo_Click(object sender, EventArgs e)
        {
            ControlloTesto();
            AreaTesto.Text = ("");
            NomeFile = "";
            titolo("Nuovo File");
        }
        private void apri_Click(object sender, EventArgs e)
        {
            ControlloTesto();
            ApriFile.ShowDialog();

            if (ApriFile.FileName != null)
            {
                try
                {
                    AreaTesto.Text = System.IO.File.ReadAllText(ApriFile.FileName);
                    TestoIniziale = System.IO.File.ReadAllText(ApriFile.FileName);
                    NomeFile = ApriFile.FileName;
                    titolo(NomeFile);
                }
                catch { }


            }
        }
        private void salva_Click(object sender, EventArgs e)
        {

            if (NomeFile != "")
            {
                try
                {
                    if (SalvaFile.FileName != null)
                    {
 
                       System.IO.File.WriteAllText(NomeFile, AreaTesto.Text);
                    }
                }
                catch { }
            }
            else
            {
                Salva();
            }
        }
        private void salvaConNome_Click(object sender, EventArgs e)
        {
            Salva();
        }
        private void esci_Click(object sender, EventArgs e)
        {
            ControlloTesto();
            Application.Exit();
        }
        private void Debug_Click(object sender, EventArgs e)
        {
            i = 0;
            s = 0;
            int inizio = 0;
            int ultimok = 0;
            azzerastack();

            if (NomeFile != "")
            {
                try
                {
                    if (SalvaFile.FileName != null)
                    {

                        System.IO.File.WriteAllText(NomeFile, AreaTesto.Text);
                    }
                }
                catch { }
            }
            else
            {
                Salva();
            }
            string Program = AreaTesto.Text;
            char separatorerighe = Convert.ToChar("\n");
            char separatoreriga = Convert.ToChar(" ");
            char separatoreetichette = Convert.ToChar(":");
            string[] righe =Program.Split(separatorerighe);
            for (int k = 0; k < righe.Length; k++)
            {
                if (righe[k].Contains(":"))
                {
                    string[] riga = righe[k].Split(separatoreriga);
                     
                    etichette[0, i] = righe[k].Substring(0, righe[k].Length - 1);
                    etichette[1, i] = Convert.ToString(k);
                    MessageBox.Show(etichette[0, i] + " " + etichette[1, i]);
                    i++;
                    
                }
                if (righe[k].Contains("Inizio"))
                {
                    inizio = k;
                }
            }
            for (int k=inizio;k<righe.Length;k++)
            {                              
                string[] riga = righe[k].Split(separatoreriga);
                
                if (riga[0] == "Muovi" && riga[2] == "in")
                {
                    if (riga[1].Contains("[") && riga[1].Contains("]"))
                    {
                        int var1 = 0;
                        string parola = riga[1];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                var1 = stack[1, j];
                            }
                        }
                        if (riga[3] == "AH")
                        {
                            AH = var1;
                        }
                        else if (riga[3] == "AL")

                        {
                            AL = var1;
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = var1;
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = var1;
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = var1;
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = var1;
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = var1;
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = var1;
                        }
                    }
                    else if (riga[3].Contains("[") && riga[3].Contains("]"))
                    {
                        int pos = 0;
                        int rip = 0;
                        string parola = riga[3];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        if (riga[1] == "AH")
                        {
                            rip = AH;
                        }
                        else if (riga[1] == "AL")

                        {
                            rip = AL;
                        }
                        else if (riga[1] == "BH")
                        {
                            rip = BH;
                        }
                        else if (riga[1] == "BL")
                        {
                            rip = BL;
                        }
                        else if (riga[1] == "CH")
                        {
                            rip = CH;
                        }
                        else if (riga[1] == "CL")
                        {
                            rip = CL;
                        }
                        else if (riga[1] == "DH")
                        {
                            rip = DH;
                        }
                        else if (riga[1] == "DL")
                        {
                            rip = DL;
                        }
                        else
                        {
                            rip = Convert.ToInt32(riga[1]);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                stack[1, j] = rip;
                            }
                        }
                    }
                    else if (int.TryParse(riga[1], out i))
                    {
                        if (riga[3] == "AH") 
                        {
                            AH = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "AL")
                        {
                            AL = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = Convert.ToInt16(riga[1]);
                        }
                    }
                    else
                    {
                        int ValVar = var(riga[1]);
                        if (riga[3] == "AH")
                            {
                                AH = ValVar;
                            }
                        else if (riga[3] == "AL")
                            {
                                AL = ValVar;
                            }
                        else if (riga[3] == "BH")
                            {
                                BH = ValVar;
                            }
                        else if (riga[3] == "BL")
                            {
                                BL = ValVar;
                            }
                        else if (riga[3] == "CH")
                            {
                                CH = ValVar;
                            }
                        else if (riga[3] == "CL")
                            {
                                CL = ValVar;
                            }
                        else if (riga[3] == "DH")
                            {
                                DH = ValVar;
                            }
                        else if (riga[3] == "DL")
                        {
                            DL = ValVar;
                        }
                    }
                    Controllo();
                }
                if (riga[0] == "Aggiungi" && riga[2] == "a")
                    {
                    if (riga[1].Contains("[") && riga[1].Contains("]"))
                    {
                        int var1 = 0;
                        string parola = riga[1];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                var1 = stack[1, j];
                            }
                        }
                        if (riga[3] == "AH")
                        {
                            AH = AH+ var1;
                        }
                        else if (riga[3] == "AL")

                        {
                            AL = AH + var1;
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = AH + var1;
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = AH + var1;
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = AH + var1;
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = AH + var1;
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = AH + var1;
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = AH + var1;
                        }
                    }
                    else if (riga[3].Contains("[") && riga[3].Contains("]"))
                    {
                        int pos = 0;
                        int rip = 0;
                        string parola = riga[3];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        if (riga[1] == "AH")
                        {
                            rip = AH;
                        }
                        else if (riga[1] == "AL")

                        {
                            rip = AL;
                        }
                        else if (riga[1] == "BH")
                        {
                            rip = DH;
                        }
                        else if (riga[1] == "BL")
                        {
                            rip = BL;
                        }
                        else if (riga[1] == "CH")
                        {
                            rip = CH;
                        }
                        else if (riga[1] == "CL")
                        {
                            rip = CL;
                        }
                        else if (riga[1] == "DH")
                        {
                            rip = DH;
                        }
                        else if (riga[1] == "DL")
                        {
                            rip = DL;
                        }
                        else
                        {
                            rip = Convert.ToInt32(riga[1]);
                        }
                        for (int j = 0; j < stackd; j++)
                        {

                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                stack[1, j] = stack[1, j] + rip;
                            }
                        }
                    }
                    else if (int.TryParse(riga[1], out i))
                    {
                        if (riga[3] == "AH")
                        {
                            AH = AH + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "AL")
                        {
                           AL = AL + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = BH + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = BL + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = CH + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = CL + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = DH + Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = DL + Convert.ToInt16(riga[1]);
                        }
                    }
                    else
                    {
                        int ValVar = var(riga[1]);
                        if (riga[3] == "AH")
                        {
                            AH = AH + ValVar;
                        }
                        else if (riga[3] == "AL")
                        {
                            AL = AL + ValVar;
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = BH + ValVar;
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = BL + ValVar;
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = CH + ValVar;
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = CL + ValVar;
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = DH + ValVar;
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = DL + ValVar;
                        }
                    }
                    Controllo();
                }
                if (riga[0] == "Sottrai" && riga[2] == "a")
                {
                    if (riga[1].Contains("[") && riga[1].Contains("]"))
                    {
                        int var1 = 0;
                        string parola = riga[1];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        for (int j = 0; j < stackd; j++)
                        {
                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                var1 = stack[1, j];
                            }
                        }
                        if (riga[3] == "AH")
                        {
                            AH = AH - var1;
                        }
                        else if (riga[3] == "AL")

                        {
                            AL = AH - var1;
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = AH - var1;
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = AH - var1;
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = AH - var1;
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = AH - var1;
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = AH - var1;
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = AH - var1;
                        }
                    }
                    else if (riga[3].Contains("[") && riga[3].Contains("]"))
                    {
                        int pos = 0;
                        int rip = 0;
                        string parola = riga[3];
                        var charsToRemove = new string[] { "[", "]" };
                        foreach (var c in charsToRemove)
                        {
                            parola = parola.Replace(c, string.Empty);
                        }
                        if (riga[1] == "AH")
                        {
                            rip = AH;
                        }
                        else if (riga[1] == "AL")

                        {
                            rip = AL;
                        }
                        else if (riga[1] == "BH")
                        {
                            rip = DH;
                        }
                        else if (riga[1] == "BL")
                        {
                            rip = BL;
                        }
                        else if (riga[1] == "CH")
                        {
                            rip = CH;
                        }
                        else if (riga[1] == "CL")
                        {
                            rip = CL;
                        }
                        else if (riga[1] == "DH")
                        {
                            rip = DH;
                        }
                        else if (riga[1] == "DL")
                        {
                            rip = DL;
                        }
                        else
                        {
                            rip = Convert.ToInt32(riga[1]);
                        }
                        for (int j = 0; j < stackd; j++)
                        {

                            if (stack[0, j] == Convert.ToInt32(parola))
                            {
                                stack[1, j] = stack[1, j] - rip;
                            }
                        }
                    }
                    bool risultato = int.TryParse(riga[1], out i);
                    if (risultato == true)
                    {
                        if (riga[3] == "AH")
                        {
                            AH = AH - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "AL")
                        {
                            AL = AL - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = BH - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = BL - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = CH - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = CL - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = DH - Convert.ToInt16(riga[1]);
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = DL - Convert.ToInt16(riga[1]);
                        }
                    }
                    else
                    {
                        int ValVar = var(riga[1]);
                        if (riga[3] == "AH")
                        {
                            AH = AH - ValVar;
                        }
                        else if (riga[3] == "AL")
                        {
                            AL = AL - ValVar;
                        }
                        else if (riga[3] == "BH")
                        {
                            BH = BH - ValVar;
                        }
                        else if (riga[3] == "BL")
                        {
                            BL = BL - ValVar;
                        }
                        else if (riga[3] == "CH")
                        {
                            CH = CH - ValVar;
                        }
                        else if (riga[3] == "CL")
                        {
                            CL = CL - ValVar;
                        }
                        else if (riga[3] == "DH")
                        {
                            DH = DH - ValVar;
                        }
                        else if (riga[3] == "DL")
                        {
                            DL = DL - ValVar;
                        }
                    }
                        Controllo();
                }
                if (riga[0] == "Salta" && riga[1] == "a")
                {
                    for(int z=0; z<i;z++)
                    {
                            
                        if(etichette[0,z]==riga[2])
                        {
                            k =Convert.ToInt16(etichette[1, z]);
                        }
                    }
                }
                if (riga[0] == "Confronto" && riga[1] == "tra" && riga[3]=="e")
                {
                    int reg1 = var(riga[2]);
                    int reg2 = var(riga[4]);
                        
                    if (reg1>reg2)
                    {
                        confronto = "reg1>reg2";
                    }
                    else if (reg1==reg2)
                    { 
                        confronto ="reg1==reg2";
                    }
                    else
                    {
                        confronto = "reg1<reg2";
                    }
                            
                }
                if (riga[0] == "Salto" && riga[1] == "MDZ" && riga[2]=="a")
                {
                    if (confronto == "reg1>reg2")
                    {
                        for (int z = 0; z < i; z++)
                        {
                            if (etichette[0, z] == riga[2])
                            {
                                k = Convert.ToInt16(etichette[1, z]);
                            }
                        }
                    }
                }
                if (riga[0] == "Salto" && riga[1] == "UAZ" && riga[2] == "a")
                {
                    if (confronto == "reg1==reg2")
                    { 
                        for (int z = 0; z < i; z++)
                        {

                            if (etichette[0, z] == riga[2])
                            {
                                k = Convert.ToInt16(etichette[1, z]);
                            }
                        }
                    }
                }
                if (riga[0] == "Salto" && riga[1] == "mDZ" && riga[2] == "a")
                {
                    if (confronto == "reg1<reg2")
                    {
                        for (int z = 0; z < i; z++)
                        {

                            if (etichette[0, z] == riga[2])
                            {
                                k = Convert.ToInt16(etichette[1, z]);
                            }
                        }
                    }
                }
                if (riga[0] == "Incrementa")
                {
                    if (riga[1] == "AH")
                    {
                        AH++;
                    }
                    else if (riga[1] == "AL")
                    {
                        AL++;
                    }
                    else if (riga[1] == "BH")
                    {
                        BH++;
                    }
                    else if (riga[1] == "BL")
                    {
                        BL++;
                    }
                    else if (riga[1] == "CH")
                    {
                        CH++;
                    }
                    else if (riga[1] == "CL")
                    {
                        CL++;
                    }
                    else if (riga[1] == "DH")
                    {
                        DH++;
                    }
                    else if (riga[1] == "DL")
                    {
                        DL++;
                    }
                    Controllo();
                }
                if (riga[0] == "Decrementa")
                {
                    if (riga[1] == "AH")
                    {
                        AH--;
                    }
                    else if (riga[1] == "AL")
                    {
                        AL--;
                    }
                    else if (riga[1] == "BH")
                    {
                        BH--;
                    }
                    else if (riga[1] == "BL")
                    {
                        BL--;
                    }
                    else if (riga[1] == "CH")
                    {
                        CH--;
                    }
                    else if (riga[1] == "CL")
                    {
                        CL--;
                    }
                    else if (riga[1] == "DH")
                    {
                        DH--;
                    }
                    else if (riga[1] == "DL")
                    {
                        DL--;
                    }
                    Controllo();
                }
                if (riga[0] == "Stacka")
                {
                    stack[1, s] = Convert.ToByte(riga[1]);
                    s++;
                    StackUpdate();
                }
                else if (riga[0] == "Poppa")
                {
                    int varpop = stack[1, k - 1];
                    if (riga[1] == "AH")
                    {
                        AH = varpop;
                    }
                    else if (riga[1] == "AL")
                    {
                        AL = varpop;
                    }
                    else if (riga[1] == "BH")
                    {
                        BH = varpop;
                    }
                    else if (riga[1] == "BL")
                    {
                        BL = varpop;
                    }
                    else if (riga[1] == "CH")
                    {
                        CH = varpop;
                    }
                    else if (riga[1] == "CL")
                    {
                        CL = varpop;
                    }
                    else if (riga[1] == "DH")
                    {
                        DH = varpop;
                    }
                    else if (riga[1] == "DL")
                    {
                        DL = varpop;
                    }
                }
                else if (riga[0] == "Fine")
                {
                    return;
                }
                else if (riga[0] == "Chiama")
                {
                    for (int z=0;z<i;z++)
                    {
                        if(etichette[0,z] == riga[1])
                        {
                            ultimok = k;
                            k = Convert.ToInt32(etichette[1, z]);
                            MessageBox.Show("Ciao");
                        }
                    }
                }
                else if (riga[0] == "FineFunzione")
                {
                    k = ultimok;
                }
                StackUpdate();
            }
        }
    }
}
