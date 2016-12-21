namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 无数据提示，loading动画选项。
    /// </summary>
    public class ChartNoDataLoadingOption
    {
        /// <summary>
        /// 默认值： '暂无数据' 
        /// 显示话术 ，'\n'指定换行
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// 默认值：'center' 
        /// 水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px） 
        /// </summary>
        public string x { get; set; }


        /// <summary>
        /// 默认值：'center' 
        /// 垂直安放位置，默认为全图居中，可选为：'center' | 'bottom' | 'top' | {number}（y坐标，单位px）
        /// </summary>
        public string y { get; set; }

        /// <summary>
        /// 默认值：null  
        /// 显示话术的文本样式（详见textStyle） 
        /// </summary>
        public ChartTextStyle textStyle { get; set; }

        /// <summary>
        /// 默认值：'spin'  
        /// loading效果，可选为：'spin' | 'bar' | 'ring' | 'whirling' | 'dynamicLine' | 'bubble'，支持外部装载
        /// </summary>
        public string effect { get; set; }

        /// <summary>
        /// 默认值：null  
        /// loading效果选项，详见zrender
        /// </summary>
        public object effectOption { get; set; }

        /// <summary>
        /// 默认值：null  
        ///指定当前进度[0~1]，个别效果有效。
        /// </summary>
        public object progress { get; set; }
    }
}
