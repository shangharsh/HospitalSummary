using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace Hospital_Summary
{
    public partial class HospitalSummary : Form
    {
        string dataSetId = "jZ0ClbXLtgz"; //UID of Dataset
        DateTime todayDate = DateTime.UtcNow.Date;
        string period = "208102"; //Eg: 208101 for 2080 Baisakh
        string orgUnitId = "aUv4lHwAFh9"; //Eg: Hospital UID
        string attributeOptionCombo = ""; //Only for ICD11 disease, UID of ICD11 disease

        string apiUrl, userName, passWord, jsonData;

        public HospitalSummary()
        {
            InitializeComponent();
        }

        void HospitalDetails()
        {
            apiUrl = "https://hmis.gov.np/hmisdemo/api/dataValueSets";
            userName = "baghauda.hosp";
            passWord = "Hmis@3344";
        }

        private void BtnHospitalPush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
        jsonData = @"
{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""I1gylzOskBs"",
            ""value"": """ + Txt1.Text + @""",
            ""comment"": ""Female Age Group  0-9 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""TTNFd2X49S6"",
            ""value"": """ + Txt2.Text + @""",
            ""comment"": ""Male Age Group  0-9 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""ciTvZ1HjQTw"",
            ""value"": """ + Txt3.Text + @""",
            ""comment"": ""Female Age Group  10-14 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""SDgsEKTs0IH"",
            ""value"": """ + Txt4.Text + @""",
            ""comment"": ""Male Age Group  10-14 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""RnH2ZpATWSI"",
            ""value"": """ + Txt5.Text + @""",
            ""comment"": ""Female Age Group  15-19 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""ffNSZ7u5Y5P"",
            ""value"": """ + Txt6.Text + @""",
            ""comment"": ""Male Age Group  15-19 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""sfmUgn8yywu"",
            ""value"": """ + Txt7.Text + @""",
            ""comment"": ""Female Age Group  20-59 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""iUcXHCikw4W"",
            ""value"": """ + Txt8.Text + @""",
            ""comment"": ""Male Age Group  20-59 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""COAFy42YNLg"",
            ""value"": """ + Txt9.Text + @""",
            ""comment"": ""Female Age Group  60-69 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""D7tJYC2XYrC"",
            ""value"": """ + Txt10.Text + @""",
            ""comment"": ""Male Age Group  60-69 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""M0yrPwi8vEK"",
            ""value"": """ + Txt11.Text + @""",
            ""comment"": ""Female Age Group  >=70 Years""
        },
        {
            ""dataElement"": ""HscG3R78Jzc"",
            ""categoryOptionCombo"": ""DYUdGTQhgf9"",
            ""value"": """ + Txt12.Text + @""",
            ""comment"": ""Male Age Group  >=70 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""I1gylzOskBs"",
            ""value"": """ + Txt13.Text + @""",
            ""comment"": ""Female Age Group  0-9 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""TTNFd2X49S6"",
            ""value"": """ + Txt14.Text + @""",
            ""comment"": ""Male Age Group  0-9 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""ciTvZ1HjQTw"",
            ""value"": """ + Txt15.Text + @""",
            ""comment"": ""Female Age Group  10-14 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""SDgsEKTs0IH"",
            ""value"": """ + Txt16.Text + @""",
            ""comment"": ""Male Age Group  10-14 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""RnH2ZpATWSI"",
            ""value"": """ + Txt17.Text + @""",
            ""comment"": ""Female Age Group  15-19 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""ffNSZ7u5Y5P"",
            ""value"": """ + Txt18.Text + @""",
            ""comment"": ""Male Age Group  15-19 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""sfmUgn8yywu"",
            ""value"": """ + Txt19.Text + @""",
            ""comment"": ""Female Age Group  20-59 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""iUcXHCikw4W"",
            ""value"": """ + Txt20.Text + @""",
            ""comment"": ""Male Age Group  20-59 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""COAFy42YNLg"",
            ""value"": """ + Txt21.Text + @""",
            ""comment"": ""Female Age Group  60-69 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""D7tJYC2XYrC"",
            ""value"": """ + Txt22.Text + @""",
            ""comment"": ""Male Age Group  60-69 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""M0yrPwi8vEK"",
            ""value"": """ + Txt23.Text + @""",
            ""comment"": ""Female Age Group  >=70 Years""
        },
        {
            ""dataElement"": ""XjuXeaVPUsr"",
            ""categoryOptionCombo"": ""DYUdGTQhgf9"",
            ""value"": """ + Txt24.Text + @""",
            ""comment"": ""Male Age Group  >=70 Years""
        }
    ]
}";
            string response = SendData(apiUrl, userName, passWord, jsonData);
        }


        private void BtnEmergencyPush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
            jsonData = @"{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
        {
            ""dataElement"": ""fuHbV1eiKs0"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt25.Text + @""",
            ""comment"": ""Female Age Group  0-9 Years""
        },
        {
            ""dataElement"": ""fuHbV1eiKs0"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt26.Text + @""",
            ""comment"": ""Male Age Group  0-9 Years""
        },
        {
            ""dataElement"": ""qQ8UCWW6YUs"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt27.Text + @""",
            ""comment"": ""Female Age Group  10-14 Years""
        },
        {
            ""dataElement"": ""qQ8UCWW6YUs"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt28.Text + @""",
            ""comment"": ""Male Age Group  10-14 Years""
        },
        {
            ""dataElement"": ""SbdW0pjvph3"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt29.Text + @""",
            ""comment"": ""Female Age Group  15-19 Years""
        },
        {
            ""dataElement"": ""SbdW0pjvph3"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt30.Text + @""",
            ""comment"": ""Male Age Group  15-19 Years""
        },
        {
            ""dataElement"": ""CLYbMAU5lhD"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt31.Text + @""",
            ""comment"": ""Female Age Group  20-59 Years""
        },
        {
            ""dataElement"": ""CLYbMAU5lhD"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt32.Text + @""",
            ""comment"": ""Male Age Group  20-59 Years""
        },
        {
            ""dataElement"": ""GaDfMW8NKGd"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt33.Text + @""",
            ""comment"": ""Female Age Group  60-69 Years""
        },
        {
            ""dataElement"": ""GaDfMW8NKGd"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt34.Text + @""",
            ""comment"": ""Male Age Group  60-69 Years""
        },
        {
            ""dataElement"": ""jXzZ2AFEqgP"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt35.Text + @""",
            ""comment"": ""Female Age Group  >=70 Years""
        },
        {
            ""dataElement"": ""jXzZ2AFEqgP"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt36.Text + @""",
            ""comment"": ""Male Age Group  >=70 Years""
        }
    ]
}";
            SendData(apiUrl, userName, passWord, jsonData);

        }

        private void BtnFreePush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
            jsonData = @"{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
        {
            ""dataElement"": ""hcc1X0ZUcwu"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt37.Text + @""",
            ""comment"": ""Heart Female""
        },
        {
            ""dataElement"": ""hcc1X0ZUcwu"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt38.Text + @""",
            ""comment"": ""Heart Male""
        },
        {
            ""dataElement"": ""vAedweDY9Ov"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt39.Text + @""",
            ""comment"": ""Kidney Female""
        },
        {
            ""dataElement"": ""vAedweDY9Ov"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt40.Text + @""",
            ""comment"": ""Kidney Male""
        },
        {
            ""dataElement"": ""sMadF784Ipm"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt41.Text + @""",
            ""comment"": ""Cancer Female""
        },
        {
            ""dataElement"": ""sMadF784Ipm"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt42.Text + @""",
            ""comment"": ""Cancer Male""
        },
        {
            ""dataElement"": ""mepsRa1P7TF"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt43.Text + @""",
            ""comment"": ""Head Injury Female""
        },
        {
            ""dataElement"": ""mepsRa1P7TF"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt44.Text + @""",
            ""comment"": ""Head Injury Male""
        },
        {
            ""dataElement"": ""NwwONXCMqqS"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt45.Text + @""",
            ""comment"": ""Spinal Injury Female""
        },
        {
            ""dataElement"": ""NwwONXCMqqS"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt46.Text + @""",
            ""comment"": ""Spinal Injury Male""
        },
        {
            ""dataElement"": ""wrUj1hRMeRR"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt47.Text + @""",
            ""comment"": ""Alzheimer Injury Female""
        },
        {
            ""dataElement"": ""wrUj1hRMeRR"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt48.Text + @""",
            ""comment"": ""Alzheimer Injury Male""
        },
        {
            ""dataElement"": ""lZRVWKdFWUz"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt49.Text + @""",
            ""comment"": ""Parkinson Injury Female""
        },
        {
            ""dataElement"": ""lZRVWKdFWUz"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt50.Text + @""",
            ""comment"": ""Parkinson Injury Male""
        },
        {
            ""dataElement"": ""P75PjLQQwYx"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt51.Text + @""",
            ""comment"": ""Sickle Cell Anaemia Female""
        },
        {
            ""dataElement"": ""P75PjLQQwYx"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt52.Text + @""",
            ""comment"": ""Sickle Cell Anaemia Male""
        }]
}";
            SendData(apiUrl,userName,passWord,jsonData);
        }

        private void BtnORCPush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
            jsonData = @"{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
       {
            ""dataElement"": ""yUNjmhz0j9s"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt53.Text + @""",
            ""comment"": ""PHC OutReach Clinic---Planned/Total No.""
        },
        {
            ""dataElement"": ""BG55tDKF0np"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt54.Text + @""",
            ""comment"": ""PHC OutReach Clinic---Conducted/Report Received""
        },
        {
            ""dataElement"": ""bKTB9K7u6DS"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt55.Text + @""",
            ""comment"": ""PHC OutReach Clinic---No. of Client Served""
        },
        {
            ""dataElement"": ""sBAeCFmRvOG"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt56.Text + @""",
            ""comment"": ""Immunization Clinic---Planned/ Total No.""
        },
        {
            ""dataElement"": ""w7FmV7f1Rcn"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt57.Text + @""",
            ""comment"": ""Immunization Clinic---Conducted/Report Received""
        },
        {
            ""dataElement"": ""TEdItLSOdos"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt58.Text + @""",
            ""comment"": ""Immunization Clinic---No. of Clients Served""
        },
        {
            ""dataElement"": ""e0HZBrBDfpg"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt59.Text + @""",
            ""comment"": ""Immunization Session---Planned/ Total No.""
        },
        {
            ""dataElement"": ""BF7zguwOCqE"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt60.Text + @""",
            ""comment"": ""Immunization Session---Conducted/Report Received""
        },
        {
            ""dataElement"": ""IY9MMZYW2Td"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt61.Text + @""",
            ""comment"": ""Hygiene Promotion Sessions---Planned/ Total No.""
        },
        {
            ""dataElement"": ""K8inoFQdq06"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt62.Text + @""",
            ""comment"": ""Hygiene Promotion Sessions---Conducted/Report Received""
        },
        {
            ""dataElement"": ""Jy09iroElNr"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt63.Text + @""",
            ""comment"": ""Hygiene Promotion Session---No of Clients Served""
        },
        {
            ""dataElement"": ""CfKB0tK9q3M"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt64.Text + @""",
            ""comment"": ""FCHV---Planned Total No.""
        },
        {
            ""dataElement"": ""Lix74hdpuwt"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt65.Text + @""",
            ""comment"": ""FCHV---Conducted/Report Received""
        },
        {
            ""dataElement"": ""GvdBFMcPVox"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt66.Text + @""",
            ""comment"": ""FCHV---No of Clients Served""
        }]
}";
            SendData(apiUrl, userName, passWord, jsonData);
        }

        private void BtnReferralPush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
            jsonData = @"{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
        {
            ""dataElement"": ""W7SEWzmObUP"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt67.Text + @""",
            ""comment"": ""Female---Referral In""
        },
        {
            ""dataElement"": ""O7vdFXujKQX"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt68.Text + @""",
            ""comment"": ""Female---Outpatient""
        },
        {
            ""dataElement"": ""cUMLBeIlaIp"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """ + Txt69.Text + @""",
            ""comment"": ""Female---In-patient""
        },
        {
            ""dataElement"": ""R8gvkj9ssaI"",
            ""categoryOptionCombo"": ""ye1QuAMRG5Z"",
            ""value"": """+ Txt70.Text + @""",
            ""comment"": ""Female---Emergency""
        },
        {
            ""dataElement"": ""W7SEWzmObUP"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt71.Text + @""",
            ""comment"": ""Male---Referral In""
        },
        {
            ""dataElement"": ""O7vdFXujKQX"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt72.Text + @""",
            ""comment"": ""Male---Outpatient""
        },
        {
            ""dataElement"": ""cUMLBeIlaIp"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt73.Text + @""",
            ""comment"": ""Male---In-patient""
        },
        {
            ""dataElement"": ""R8gvkj9ssaI"",
            ""categoryOptionCombo"": ""PflKpozpO7b"",
            ""value"": """ + Txt74.Text + @""",
            ""comment"": ""Male---Emergency""
        }]
}";
            SendData(apiUrl, userName, passWord, jsonData);
        }

        private void BtnBedPush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
            jsonData = @"{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
        {
            ""dataElement"": ""hE0Kl0AKRKj"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt75.Text + @""",
            ""comment"": ""Sanctioned Bed""
        },
        {
            ""dataElement"": ""XSzX9nccK7m"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt76.Text + @""",
            ""comment"": ""Operation in-patient bed""
        },
        {
            ""dataElement"": ""hRg33LNWtxu"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt77.Text + @""",
            ""comment"": ""Emergency Bed""
        },
        {
            ""dataElement"": ""e7awSzM03vh"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt78.Text + @""",
            ""comment"": ""Total Patients Admitted""
        },
        {
            ""dataElement"": ""mVPlNZIq82F"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt79.Text + @""",
            ""comment"": ""Total InPatients Days""
        }]
}";
            SendData(apiUrl, userName, passWord, jsonData);
        }

        private void BtnDiagnosticPush_Click(object sender, EventArgs e)
        {
            HospitalDetails();
            jsonData = @"{
    ""dataSet"": """ + dataSetId + @""",
    ""completeDate"": """ + todayDate.ToString("yyyy-MM-dd") + @""",
    ""period"": """ + period + @""",
    ""orgUnit"": """ + orgUnitId + @""",
    ""attributeOptionCombo"": """",
    ""dataValues"": [
        {
            ""dataElement"": ""RXIa0TIoAP4"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt80.Text + @""",
            ""comment"": ""X-ray Number""
        },
        {
            ""dataElement"": ""Hy2ikWKzAUh"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt81.Text + @""",
            ""comment"": ""USG-Number""
        },
        {
            ""dataElement"": ""gglzlE7oJpI"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt82.Text + @""",
            ""comment"": ""Echo-Number""
        },
        {
            ""dataElement"": ""yVhL13Rc3Gw"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt83.Text + @""",
            ""comment"": ""EEG-Number""
        },
        {
            ""dataElement"": ""HXPj1cIqZIC"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt84.Text + @""",
            ""comment"": ""ECG-Number""
        },
        {
            ""dataElement"": ""aBbZ4GirNpN"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt85.Text + @""",
            ""comment"": ""TreadMill""
        },
        {
            ""dataElement"": ""zQnc9f0Gq8Z"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt86.Text + @""",
            ""comment"": ""CT-Scan""
        },
        {
            ""dataElement"": ""gT5hXh5IQ8Y"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt87.Text + @""",
            ""comment"": ""MRI-Number""
        },
        {
            ""dataElement"": ""rU9EUoLmd1K"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt88.Text + @""",
            ""comment"": ""Endoscopy-Persons""
        },
        {
            ""dataElement"": ""CUrV07L8274"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt89.Text + @""",
            ""comment"": ""Colonoscopy-Persons""
        },
        {
            ""dataElement"": ""Ly477FanXE3"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt90.Text + @""",
            ""comment"": ""Bronchoscopy-Persons""
        },
        {
            ""dataElement"": ""d7xsrk6ZliX"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt91.Text + @""",
            ""comment"": ""Nuclear Medicine-Persons""
        },
        {
            ""dataElement"": ""vigLadIlROn"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt92.Text + @""",
            ""comment"": ""Mammogram-Persons""
        },
        {
            ""dataElement"": ""ztdpCtP5eOM"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt93.Text + @""",
            ""comment"": ""Cystoscopy-Persons""
        },
        {
            ""dataElement"": ""F8mMHpJm9cd"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt94.Text + @""",
            ""comment"": ""Dexa Scan-Persons""
        },
        {
            ""dataElement"": ""TbGgV5AODKc"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt95.Text + @""",
            ""comment"": ""DTPA Scan-Persons""
        },
        {
            ""dataElement"": ""ctyxkCUBEbX"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt96.Text + @""",
            ""comment"": ""ECT-Persons""
        },
        {
            ""dataElement"": ""ScWyls97aqY"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt97.Text + @""",
            ""comment"": ""TMS-Persons""
        },
        {
            ""dataElement"": ""UTJQ3DnKBGP"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt98.Text + @""",
            ""comment"": ""Total laboratory Services Provided-Persons""
        },
        {
            ""dataElement"": ""sFkotLeU4nk"",
            ""categoryOptionCombo"": ""kdsirVNKdhm"",
            ""value"": """ + Txt99.Text + @""",
            ""comment"": ""Other(if any)-Persons""
        }]
}";
            SendData(apiUrl, userName, passWord, jsonData);
        }


        public static string SendData(string apiUrl, string userName, string passWord, string jsonData)
        {
            string ReturnValue = "";

            // Create a web request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/json";

            // Add Basic Authentication header
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(userName + ":" + passWord));
            request.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

            try
            {
                // Write JSON data to the request stream
                using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
                {
                    writer.Write(jsonData);
                    writer.Flush();
                }

                // Get the response
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    // Read the response
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            string responseJson = reader.ReadToEnd();
                            ReturnValue = responseJson;
                            var responseObject = JObject.Parse(responseJson);
                            MessageBox.Show((string)responseObject["description"], "Success");
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                ReturnValue = ex.Message;
            }
            return ReturnValue;
        }
    }
}

