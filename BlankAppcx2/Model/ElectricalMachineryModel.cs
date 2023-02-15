using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    public class ElectricalMachineryModel: ModelBase
    {
        private int Id;
        public int ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); }
        }
        /// <summary>
        /// 电机表机器人序列号ElectricalMachineryTableRobotnumber
        /// </summary>
        private string electricalmachinerytablerobotnumber;
        public string? ElectricalMachineryTableRobotnumber
        {
            get { return electricalmachinerytablerobotnumber; }
            set { electricalmachinerytablerobotnumber = value; OnPropertyChanged("ElectricalMachineryTableRobotnumber"); }
        }
        /// <summary>
        /// 电机表作业号
        /// </summary>
        private string electricalmachinerytablejobnumber;
        public string? ElectricalMachineryTableJobNumber
        {
            get { return electricalmachinerytablejobnumber; }
            set { electricalmachinerytablejobnumber = value; OnPropertyChanged("ElectricalMachineryTableJobNumber"); }
        }
        /// <summary>
        /// 电机表轴
        /// </summary>
        private int electricalmachinerytableaxle;
        public int ElectricalMachineryTableAxle
        {
            get { return electricalmachinerytableaxle; }
            set { electricalmachinerytableaxle = value; OnPropertyChanged("ElectricalMachineryTableAxle"); }
        }
        /// <summary>
        /// 电机表型号
        /// </summary>
        private string electricalmachinerytablenummodel;
        public string? ElectricalMachineryTableNumModel
        {
            get { return electricalmachinerytablenummodel; }
            set { electricalmachinerytablenummodel = value; OnPropertyChanged("ElectricalMachineryTableNumModel"); }
        }
        /// <summary>
        /// 电机表扫描条码
        /// </summary>
        private string electricalmachinerytablescanthebarcode;
        public string? ElectricalMachineryTableScanTheBarcode
        {
            get { return electricalmachinerytablescanthebarcode; }
            set { electricalmachinerytablescanthebarcode = value; OnPropertyChanged("ElectricalMachineryTableScanTheBarcode"); }
        }
        /// <summary>
        /// 电机表描述
        /// </summary>
        private string electricalmachinerytabledescribe;
        public string? ElectricalMachineryTableDescribe
        {
            get { return electricalmachinerytabledescribe; }
            set { electricalmachinerytabledescribe = value; OnPropertyChanged("ElectricalMachineryTableDescribe"); }
        }
        /// <summary>
        /// 电机表物料编码
        /// </summary>
        private string electricalmachinerytablematerialcode;
        public string? ElectricalMachineryTableMaterialCode
        {
            get { return electricalmachinerytablematerialcode; }
            set { electricalmachinerytablematerialcode = value; OnPropertyChanged("ElectricalMachineryTableMaterialCode"); }
        }
        /// <summary>
        /// 电机表物料描述
        /// </summary>
        private string electricalmachinerytablematerialdescription;
        public string? ElectricalMachineryTableMaterialDescription
        {
            get { return electricalmachinerytablematerialdescription; }
            set { electricalmachinerytablematerialdescription = value; OnPropertyChanged("ElectricalMachineryTableMaterialDescription"); }
        }
        /// <summary>
        /// 电机表序列号
        /// </summary>
        private string electricalmachinerytableserialnumber;
        public string? ElectricalMachineryTableSerialNumber
        {
            get { return electricalmachinerytableserialnumber; }
            set { electricalmachinerytableserialnumber = value; OnPropertyChanged("ElectricalMachineryTableSerialNumber"); }
        }
        /// <summary>
        /// 电机表装配工
        /// </summary>
        private string electricalmachinerytableassembler;
        public string? ElectricalMachineryTableAssembler
        {
            get { return electricalmachinerytableassembler; }
            set { electricalmachinerytableassembler = value; OnPropertyChanged("ElectricalMachineryTableAssembler"); }
        }
        /// <summary>
        /// 电机表日期
        /// </summary>
        private DateTime electricalmachinerytabledatetime;
        public DateTime ElectricalMachineryTableDateTime
        {
            get { return electricalmachinerytabledatetime; }
            set { electricalmachinerytabledatetime = DateTime.Now; OnPropertyChanged("ElectricalMachineryTableDateTime"); }
        }
    }

    public class Result5s
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ElectricalMachineryModel> items { get; set; }
    }

    public class Root5s
    {
        /// <summary>
        /// 
        /// </summary>
        public Result5s result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string targetUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unAuthorizedRequest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string __abp { get; set; }
    }
}
