namespace EChartPackage.ChartCommon
{
    /// <summary>
    /// 文字样式
    /// </summary>
    public class ChartTextStyle
    {
        /// <summary>
        /// 默认值：各异
        /// 颜色
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// 默认值：'none' 
        /// 修饰，仅对tooltip.textStyle生效 
        /// </summary>
        public string decoration { get; set; }

        /// <summary>
        /// 默认值：各异 
        /// 水平对齐方式，可选为：'left' | 'right' | 'center' 
        /// </summary>
        public string align { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 垂直对齐方式，可选为：'top' | 'bottom' | 'middle' 
        /// </summary>
        public string baseline { get; set; }

        /// <summary>
        /// 默认值：'Arial, Verdana, sans-serif'
        /// 字体系列  
        /// </summary>
        public string fontFamily { get; set; }

        /// <summary>
        /// 默认值：12
        /// 字号，单位px  
        /// </summary>
        public object fontSize { get; set; }

        /// <summary>
        /// 默认值：'normal'
        /// 字体系列  
        /// </summary>
        public string fontStyle { get; set; }

        /// <summary>
        /// 默认值：'normal'
        /// 粗细，可选为：'normal' | 'bold' | 'bolder' | 'lighter' | 100 | 200 |... | 900  
        /// </summary>
        public string fontWeight { get; set; }
    }
}
