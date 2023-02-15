using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    
    public class KeyComponents:ModelBase
    {
        private int Id;
        public int ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); }
        }
        /// <summary>
        /// 关键键采集机器人序列号
        /// </summary>
        private string keycomponentsandtablerobotnumber;
        public string? KeyComponentsAndTableRobotnumber
        {
            get { return keycomponentsandtablerobotnumber; }
            set { keycomponentsandtablerobotnumber = value; OnPropertyChanged("KeyComponentsAndTableRobotnumber"); }
        }
        /// <summary>
        /// 关键键采集非标作业号
        /// </summary>
        private string keycomponentsandtablenonstandardnumber;
        public string? KeyComponentsAndTableNonStandardNumber
        {
            get { return keycomponentsandtablenonstandardnumber; }
            set { keycomponentsandtablenonstandardnumber = value; OnPropertyChanged("KeyComponentsAndTableNonStandardNumber"); }
        }
        /// <summary>
        /// 关键键采集扫描条码
        /// </summary>
        private string keycomponentsandtablescanthebarcode;
        public string? KeyComponentsAndTableScanTheBarcode
        {
            get { return keycomponentsandtablescanthebarcode; }
            set { keycomponentsandtablescanthebarcode = value; OnPropertyChanged("KeyComponentsAndTableScanTheBarcode"); }
        }
        /// <summary>
        /// 关键键采集作业号
        /// </summary>
        private string keycomponentsandtablejobnumber;
        public string? KeyComponentsAndTableJobNumber
        {
            get { return keycomponentsandtablejobnumber; }
            set { keycomponentsandtablejobnumber = value; OnPropertyChanged("KeyComponentsAndTableJobNumber"); }
        }
        /// <summary>
        /// 关键键采集轴
        /// </summary>
        private int keycomponentsandtableaxle;
        public int KeyComponentsAndTableAxle
        {
            get { return keycomponentsandtableaxle; }
            set { keycomponentsandtableaxle = value; OnPropertyChanged("KeyComponentsAndTableAxle"); }
        }
        /// <summary>
        /// 关键键采集型号
        /// </summary>
        private string keycomponentsandtablemodel;
        public string? KeyComponentsAndTableNumModel
        {
            get { return keycomponentsandtablemodel; }
            set { keycomponentsandtablemodel = value; OnPropertyChanged("KeyComponentsAndTableModel"); }
        }
        /// <summary>
        /// 关键键采集序列号
        /// </summary>
        private string keycomponentsandtableserialnumber;
        public string? KeyComponentsAndTableNumber
        {
            get { return keycomponentsandtableserialnumber; }
            set { keycomponentsandtableserialnumber = value; OnPropertyChanged("KeyComponentsAndTableSerialNumber"); }
        }
        /// <summary>
        /// 关键键采集描述
        /// </summary>
        private string keycomponentsandtabledescribe;
        public string? KeyComponentsAndTableDescribe
        {
            get { return keycomponentsandtabledescribe; }
            set { keycomponentsandtabledescribe = value; OnPropertyChanged("KeyComponentsAndTableDescribe"); }
        }
        /// <summary>
        /// 关键键采集物料编码
        /// </summary>
        private string keycomponentsandtablematerialcode;
        public string? KeyComponentsAndTableMaterialCode {
            get { return keycomponentsandtablematerialcode; }
            set { keycomponentsandtablematerialcode = value; OnPropertyChanged("KeyComponentsAndTableMaterialCode"); }
        }
        /// <summary>
        /// 关键键采集物料描述
        /// </summary>
      
        private string keycomponentsandtablematerialdescription;
        public string? KeyComponentsAndTableMaterialDescription {
            get { return keycomponentsandtablematerialdescription; }
            set { keycomponentsandtablematerialdescription = value; OnPropertyChanged("KeyComponentsAndTableMaterialDescription"); }
        }
        /// <summary>
        /// 关键键采集装配工
        /// </summary>
        
        private string keycomponentsandtableassembler;
        public string? KeyComponentsAndTableAssembler
        {
            get { return keycomponentsandtableassembler; }
            set { keycomponentsandtableassembler = value; OnPropertyChanged("KeyComponentsAndTableAssembler"); }
        }
        /// <summary>
        /// 关键键采集日期
        /// </summary>
        private DateTime keycomponentsandtabledateime;
        public DateTime KeyComponentsAndTableDateTime
        {
            get { return keycomponentsandtabledateime; }
            set { keycomponentsandtabledateime = DateTime.Now; OnPropertyChanged("KeyComponentsAndTableDateTime"); }
        }
    }

   
    public class Results
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<KeyComponents> items { get; set; }
    }

    public class Root4s
    {
        /// <summary>
        /// 
        /// </summary>
        public Results result { get; set; }
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
