namespace EChartPackage.ChartCommon
{
    public class ChartCom
    {
        /// <summary>
        /// 全图默认背景，支持rgba，默认为无(null)，透明，同'rgba(0,0,0,0)' 
        /// </summary>
        public string backgroundColor { get; set; }

        /// <summary>
        /// 数值系列的颜色列表，可配数组，eg：['#87cefa', 'rgba(123,123,123,0.5)','...']，当系列数量个数比颜色列表长度大时将循环选取 
        /// </summary>
        public string[] color { get; set; }

        /// <summary>
        /// boolean | string} false，非IE8-支持渲染为图片，可设为true或指定图片格式（png | jpeg），渲染为图片后实例依然可用（如setOption，resize等），但各种交互失效
        /// </summary>
        public object renderAsImage { get; set; }

        /// <summary>
        /// 是否启用拖拽重计算特性，默认关闭
        /// </summary>
        public object calculable { get; set; }

        /// <summary>
        /// 是否开启动画，默认开启,建议IE8-关闭
        /// </summary>
        public object animation { get; set; }

    }
}
