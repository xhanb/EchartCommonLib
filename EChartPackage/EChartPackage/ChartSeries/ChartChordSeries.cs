using System.Collections.Generic;
using EChartPackage.ChartCommon;

namespace EChartPackage.ChartSeries
{
    /// <summary>
    /// 适用类型:和弦图
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据
    /// </summary>
    public class ChartChordSeries : ChartComSeries
    {
        /// <summary>
        /// 默认值：null
        /// 节点分类, 详见图数据结构表示中的categories
        /// </summary>
        public string[] categories { get; set; }

        /// <summary>
        /// 和弦图的顶点数据
        /// </summary>
        public List<nodes> nodes { get; set; }

        /// <summary>
        /// 默认值：[]
        /// 和弦图的边数据, 和matrix二选一 详见图数据结构表示中的links
        /// </summary>
        public List<links> links { get; set; }

        /// <summary>
        /// 默认值：[]
        /// 和弦图的邻接矩阵, 和links二选一 详见图数据结构表示中的matrix
        /// </summary>
        public List<string[]> matrix { get; set; }

        /// <summary>
        /// 默认值:true
        /// ribbonType的和弦图节点使用扇形绘制，边使用有大小端的ribbon绘制，可以表示出边的权重，图的节点边之间必须是双向边，非ribbonType的和弦图节点使用symbol绘制，边使用贝塞尔曲线，不能表示边的权重，但是可以使用单向边
        /// </summary>
        public object ribbonType { get; set; }

        /// <summary>
        /// 默认值：null
        /// 同series（直角系）, ribbonType为false时有效
        /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        ///'circle' | 'rectangle' | 'triangle' | 'diamond' |
        ///'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond'
        ///另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星
        ///自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 
        /// </summary>
        public string symbol { get; set; }

        /// <summary>
        /// 节点的大小, ribbonType为false时有效 
        /// </summary>
        public object symbolSize { get; set; }

        /// <summary>
        /// 默认值：10
        /// 顶点数据映射成symbol半径后的最小半径, ribbonType为false时有效 
        /// </summary>
        public object minRadius { get; set; }

        /// <summary>
        /// 默认值：20
        /// 顶点数据映射成symbol半径后的最大半径, ribbonType为false时有效 
        /// </summary>
        public object maxRadius { get; set; }

        /// <summary>
        /// 默认值：false
        /// 是否显示刻度, ribbonType为true时有效
        /// </summary>
        public object showScale { get; set; }

        /// <summary>
        /// 默认值：false
        /// 是否显示刻度文字, ribbonType为true时有效 
        /// </summary>
        public object showScaleText { get; set; }

        /// <summary>
        /// 默认值：2
        /// 每个sector之间的间距(用角度表示) 
        /// </summary>
        public object padding { get; set; }

        /// <summary>
        /// 默认值：'none' 
        /// 数据排序， 可以取none, ascending, descending
        /// </summary>
        public object sort { get; set; }

        /// <summary>
        /// 默认值：'none' 
        /// 数据排序（弦）， 可以取none, ascending, descending
        /// </summary>
        public object sortSub { get; set; }

        /// <summary>
        /// 默认值：false
        /// 显示是否顺时针 
        /// </summary>
        public object clockWise { get; set; }

    }

    /// <summary>
    /// 和弦图和力导向图等图的数据表示需要一个图的数据结构，Echarts中可以使用nodes或者data来表示节点数据，用links或者邻接矩阵matrix表示边, 对于每个节点可以通过一个额外的category配置节点的分类。
    /// </summary>
    public class links
    {
        /// <summary>
        /// 源节点的index或者源节点的name 
        /// </summary>
        public object source { get; set; }

        /// <summary>
        /// 目标节点的index或者目标节点的name 
        /// </summary>
        public object target { get; set; }

        /// <summary>
        /// 边的权重 
        /// </summary>
        public object weight { get; set; }
    }

    public class nodes
    {
        /// <summary>
        /// 节点名称 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 节点标签名称，默认显示name作为标签 
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// 节点值，如果不设置会取所有边的权重(weight)和 
        /// </summary>
        public object value { get; set; }

        /// <summary>
        /// 默认值：false
        ///是否忽略该节点
        /// </summary>
        public object ignore { get; set; }

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
        /// 强制指定节点的大小 
        /// </summary>
        public object symbolSize { get; set; }

        /// <summary>
        /// 默认值：0
        /// 节点的 category index 
        /// </summary>
        public object category { get; set; }

        /// <summary>
        /// 详见 itemStyle，注意力导向图单个节点的 itemStyle 中没有 nodeStyle 的配置项，而是直接使用 normal(emphasis) 下的 color, borderWidth 和 borderColor
        /// </summary>
        public ChartItemStyle itemStyle { get; set; }
    }
}
