namespace EChartPackage.ChartSeries
{
    /// <summary>
    /// 适用类型:饼图
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据
    /// </summary>
    public class ChartPieSeries : ChartComSeries
    {
        /// <summary>
        /// 默认值：['50%', '50%'] 
        /// 圆心坐标，支持绝对值（px）和百分比，百分比计算min(width, height) * 50% 
        /// </summary>
        public object center { get; set; }

        /// <summary>
        /// 默认值：[0, '75%'] 
        /// 半径，支持绝对值（px）和百分比，百分比计算比，min(width, height) / 2 * 75%， 传数组实现环形图，[内半径，外半径] 
        /// </summary>
        public object radius { get; set; }

        /// <summary>
        /// 默认值：90
        /// 开始角度, 饼图（90）、仪表盘（225），有效输入范围：[-360,360]
        /// </summary>
        public object startAngle { get; set; }

        /// <summary>
        /// 默认值：0
        /// 最小角度，可用于防止某item的值过小而影响交互 
        /// </summary>
        public object minAngle { get; set; }

        /// <summary>
        /// 默认值：true
        /// 显示是否顺时针 
        /// </summary>
        public object clockWise { get; set; }

        /// <summary>
        /// 默认值：null
        /// 南丁格尔玫瑰图模式，'radius'（半径） | 'area'（面积）
        /// </summary>
        public string roseType { get; set; }

        /// <summary>
        /// 默认值：10
        /// 选中是扇区偏移量 
        /// </summary>
        public object selectedOffset { get; set; }

        /// <summary>
        /// 默认值：null
        /// 选中模式，默认关闭，可选single，multiple 
        /// </summary>
        public object selectedMode { get; set; }

        /// <summary>
        /// 默认值：true
        /// 是否启用图例（legend）hover时的联动响应（高亮显示） 
        /// </summary>
        public object legendHoverLink { get; set; }

    }
}
