using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    public class GearCaseModel: ModelBase
    {
        private int Id;
        public int ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); }
        }
        /// <summary>
        /// 齿轮箱表机器人序列号
        /// </summary>
        private string gearcasetablerobotnumber;
        public string? GearCaseTableRobotnumber
        {
            get { return gearcasetablerobotnumber; }
            set { gearcasetablerobotnumber = value; OnPropertyChanged("GearCaseTableRobotnumber"); }
        }
        /// <summary>
        /// 齿轮箱表作业号
        /// </summary>
        private string gearcasetablejobnumber;
        public string? GearCaseTableJobNumber
        {
            get { return gearcasetablejobnumber; }
            set { gearcasetablejobnumber = value; OnPropertyChanged("GearCaseTableJobNumber"); }
        }
        /// <summary>
        /// 齿轮箱表轴
        /// </summary>
        private int gearcasetableaxle;
        public int GearCaseTableAxle
        {
            get { return gearcasetableaxle; }
            set { gearcasetableaxle = value; OnPropertyChanged("GearCaseTableAxle"); }
        }
        /// <summary>
        /// 齿轮箱表型号
        /// </summary>
        private string gearcasetablenummodel;
        public string? GearCaseTableNumModel {
            get { return gearcasetablenummodel; }
            set { gearcasetablenummodel = value; OnPropertyChanged("GearCaseTableNumModel"); }
        }
        /// <summary>
        /// 齿轮箱表扫描条码
        /// </summary>
        private string gearcasetablescanthebarcode;
        public string? GearCaseTableScanTheBarcode
        {
            get { return gearcasetablescanthebarcode; }
            set { gearcasetablescanthebarcode = value; OnPropertyChanged("GearCaseTableScanTheBarcode"); }
        }
        /// <summary>
        /// 齿轮箱表描述
        /// </summary>
        private string gearcasetabledescribe;
        public string? GearCaseTableDescribe
        {
            get { return gearcasetabledescribe; }
            set { gearcasetabledescribe = value; OnPropertyChanged("GearCaseTableDescribe"); }
        }
        /// <summary>
        /// 齿轮箱表物料编码
        /// </summary>
        private string gearcasetablematerialcode;
        public string? GearCaseTableMaterialCode
        {
            get { return gearcasetablematerialcode; }
            set { gearcasetablematerialcode = value; OnPropertyChanged("GearCaseTableMaterialCode"); }
        }
        /// <summary>
        /// 齿轮箱表物料描述
        /// </summary>
        private string gearcasetablematerialdescription;
        public string? GearCaseTableMaterialDescription
        {
            get { return gearcasetablematerialdescription; }
            set { gearcasetablematerialdescription = value; OnPropertyChanged("GearCaseTableMaterialDescription"); }
        }
        /// <summary>
        /// 齿轮箱表序列号
        /// </summary>
        private string gearcasetableserialnumber;
        public string? GearCaseTableSerialNumber
        {
            get { return gearcasetableserialnumber; }
            set { gearcasetableserialnumber = value; OnPropertyChanged("GearCaseTableSerialNumber"); }
        }
        /// <summary>
        /// 齿轮箱表装配工
        /// </summary>
        private string gearcasetableworker;
        public string? GearCaseTableWorker
        {
            get { return gearcasetableworker; }
            set { gearcasetableworker = value; OnPropertyChanged("GearCaseTableWorker"); }
        }
        /// <summary>
        /// 齿轮箱表装配时间
        /// </summary>
        private DateTime? gearcasetabletime;
        public DateTime? GearCaseTableTime
        {
            get { return gearcasetabletime; }
            set { gearcasetabletime = value; OnPropertyChanged("GearCaseTableTime"); }
        }
        /// <summary>
        /// 齿轮箱表注油标准值
        /// </summary>
        private string gearcasetablefillingstandard;
        public string? GearCaseTableFillingStandard
        {
            get { return gearcasetablefillingstandard; }
            set { gearcasetablefillingstandard = value; OnPropertyChanged("GearCaseTableFillingStandard"); }
        }
        /// <summary>
        /// 齿轮箱表注油实际值
        /// </summary>
        private string gearcasetablefillingactual;
        public string? GearCaseTableActualValueOfOilInjection
        {
            get { return gearcasetablefillingactual; }
            set { gearcasetablefillingactual = value; OnPropertyChanged("GearCaseTableActualValueOfOilInjection"); }
        }
        /// <summary>
        /// 齿轮箱表偏差值
        /// </summary>
        private string gearcasetabledeviationvalue;
        public string? GearCaseTableDeviationValue
        {
            get { return gearcasetabledeviationvalue; }
            set { gearcasetabledeviationvalue = value; OnPropertyChanged("GearCaseTableDeviationValue"); }
        }
        /// <summary>
        /// 齿轮箱表上传结果
        /// </summary>
        private string gearcasetableuploadresults;
        public string? GearCaseTableUploadResults
        {
            get { return gearcasetableuploadresults; }
            set { gearcasetableuploadresults = value; OnPropertyChanged("GearCaseTableUploadResults"); }
        }
    }
    public class Result6s
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<GearCaseModel> items { get; set; }
    }

    public class Root6s
    {
        /// <summary>
        /// 
        /// </summary>
        public Result6s result { get; set; }
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
