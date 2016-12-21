namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 力导向图中的边样式
    /// </summary>
   public class ChartLinkStyle
    {
        /// <summary>
        /// 默认值：'line' 
        /// 线条类型，可选为：'curve'（曲线） | 'line'（直线） 
        /// </summary>
       public string type { get; set; }

       /// <summary>
       /// 默认值：'#5182ab' 
       /// 线条颜色 
       /// </summary>
       public string color { get; set; }

       /// <summary>
       /// 默认值：1
       /// 线宽  
       /// </summary>
       public object width { get; set; }
    }
}
