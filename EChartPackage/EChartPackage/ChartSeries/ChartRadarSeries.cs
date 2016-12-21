using System.Collections.Generic;

namespace EChartPackage.ChartSeries
{
    /// <summary>
    /// 适用类型:雷达图
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据
    /// </summary>
    public class ChartRadarSeries : ChartComSeries
    {
        /// <summary>
        /// 默认值：0
        /// 极坐标索引 
        /// </summary>
        public object polarIndex { get; set; }

        /// <summary>
        /// 默认值：null
        /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        ///'circle' | 'rectangle' | 'triangle' | 'diamond' |
        ///'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond'
        ///另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星
        ///自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 
        /// </summary>
        public string symbol { get; set; }

        
        /// <summary>
        /// 适用类型：折线图，散点图 
        /// 默认值：2 | 4
        /// 标志图形大小，可计算特性启用情况建议增大以提高交互体验。实现气泡图时symbolSize需为Function，气泡大小取决于该方法返回值，传入参数为当前数据项（value数组）
        /// </summary>
        public object symbolSize { get; set; }

        /// <summary>
        /// 适用类型:折线图 ，散点图
        /// 默认值：null
        /// 标志图形旋转角度[-180,180]
        /// </summary>
        public object symbolRotate { get; set; }

        /// <summary>
        /// 默认值：true
        /// 是否启用图例（legend）hover时的联动响应（高亮显示） 
        /// </summary>
        public object legendHoverLink { get; set; }

        /// <summary>
        /// 默认值：[]
        /// 适用类型：雷达图
        /// 系列中的数据内容数组
        /// </summary>
        public new List<ChartRadarSeriesData> data { get; set; }
    }

    /// <summary>
    /// series序列组的数据
    /// </summary>
    public class ChartRadarSeriesData
    {
        public string name { get; set; }
        public List<object> value { get; set; }
    }
}
