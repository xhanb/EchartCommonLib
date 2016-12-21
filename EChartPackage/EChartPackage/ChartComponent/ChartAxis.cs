using System.Collections.Generic;
using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 坐标轴(个别选项仅在个别类型时有效)
    /// 坐标轴有三种类型，类目型、数值型和时间型，他们的区别在于：
    /// 类目型：需要指定类目列表，坐标轴内有且仅有这些指定类目坐标
    /// 数值型：需要指定数值区间，不指定时则自定计算数值范围，坐标轴内包含数值区间内容全部坐标
    /// 时间型：时间型坐标轴用法同数值型，只是目标处理和格式化显示时会自动转变为时间，并且随着时间跨度的不同自动切换需要显示的时间粒度
    /// 个别选项仅在个别类型时有效
    /// </summary>
    public class ChartAxis
    {
        /// <summary>
        /// 默认值：'category' | 'value' | 'time'
        /// 适用类型: 通用
        /// 坐标轴类型，横轴默认为类目型'category'，纵轴默认为数值型'value'
        /// </summary>
        public object type { get; set; }

        /// <summary>
        /// 默认值：true
        /// 适用类型:通用
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值：0
        /// 适用类型:通用
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public object zlevel { get; set; }

        /// <summary>
        /// 默认值：0
        /// 适用类型:通用	
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public object z { get; set; }

        /// <summary>
        /// 默认值：'bottom' | 'left'
        /// 适用类型:通用
        /// 坐标轴类型，横轴默认为类目型'bottom'，纵轴默认为数值型'left'，可选为：'bottom' | 'top' | 'left' | 'right'
        /// </summary>
        public string position { get; set; }

        /// <summary>
        /// 默认值：''
        /// 适用类型:数值型，时间型
        /// 坐标轴名称，默认为空
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 默认值：'end'
        /// 适用类型:数值型，时间型
        /// 坐标轴名称位置，默认为'end'，可选为：'start' | 'end'
        /// </summary>
        public string nameLocation { get; set; }

        /// <summary>
        /// 默认值：{}
        /// 适用类型:数值型，时间型
        /// 坐标轴名称文字样式，默认取全局配置，颜色跟随axisLine主色，可设
        /// </summary>
        public object nameTextStyle { get; set; }

        /// <summary>
        /// 适用类型:类目型,数值型，时间型
        /// 功能1：类目起始和结束两端空白策略，见下图，默认为true留空，false则顶头，默认值：true
        /// 功能2：坐标轴两端空白策略，数组内数值代表百分比，[原始数据最小值与最终最小值之间的差额，原始数据最大值与最终最大值之间的差额]，默认值：[0, 0]
        /// </summary>
        public object boundaryGap { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型:数值型，时间型
        /// 指定的最小值，eg: 0，默认无，会自动根据具体数值调整，指定后将忽略boundaryGap[0]
        /// </summary>
        public object min { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型:数值型，时间型
        /// 指定的最大值，eg: 100，默认无，会自动根据具体数值调整，指定后将忽略boundaryGap[1]
        /// </summary>
        public object max { get; set; }

        /// <summary>
        /// 默认值：false
        /// 适用类型:数值型，时间型
        /// 脱离0值比例，放大聚焦到最终_min，_max区间
        /// </summary>
        public object scale { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型:数值型，时间型
        /// 分割段数，不指定时根据min、max算法调整
        /// </summary>
        public object splitNumber { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 适用类型:通用
        /// 坐标轴线，默认显示
        /// </summary>
        public AxisLine axisLine { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 适用类型:通用
        /// 坐标轴小标记，默认不显示
        /// </summary>
        public AxisTick axisTick { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 适用类型:通用
        /// 坐标轴文本标签
        /// </summary>
        public AxisLabel axisLabel { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 适用类型:通用
        /// 分隔线，默认显示
        /// </summary>
        public SplitLine splitLine { get; set; }

        /// <summary>
        /// 默认值：各异
        /// 适用类型:通用
        /// 分隔区域，默认不显示
        /// </summary>
        public SplitArea splitArea { get; set; }

        /// <summary>
        /// 默认值：[]
        /// 适用类型:类目型
        /// 类目列表，同时也是label内容
        /// 注意：当需要显示类目型坐标轴文本标签数组，指定label内容时，将参数‘object’替换为‘AxisData’
        /// </summary>
        public List<object> data { get; set; }
    }
    /// <summary>
    /// 坐标轴线，默认显示且带如下样式
    /// </summary>
    public class AxisLine
    {
        /// <summary>
        /// 默认值：true
        /// 适用类型:通用
        /// 是否显示，默认为true，设为false后下面都没意义了
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值：true
        /// 适用类型:通用
        /// 定位到垂直方向的0值坐标上
        /// </summary>
        public object onZero { get; set; }

        /// <summary>
        /// 默认值：{
        ///     color: '#48b',
        ///     width: 2,
        ///     type: 'solid'
        /// }   
        /// 适用类型:通用
        /// （详见lineStyle）属性lineStyle控制线条样式
        /// </summary>
        public object lineStyle { get; set; }
    }
    /// <summary>
    /// 坐标轴小标记，数值轴和时间轴默认不显示，类目轴默认显示
    /// </summary>
    public class AxisTick
    {
        /// <summary>
        /// 默认值：  false（数值轴和时间轴） true（类目轴）
        /// 适用类型:通用
        /// 是否显示，默认为false，设为true后下面为默认样式
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值：'auto'
        /// 适用类型:类目型
        /// 小标记显示挑选间隔，默认为'auto'，可选为： 
        /// 'auto'（随axisLabel，自动隐藏显示不下的） | 0（全部显示） | 
        /// {number}（用户指定选择间隔） 
        /// {function}函数回调，传递参数[index，data[index]]，返回true显示，返回false隐藏
        /// </summary>
        public object interval { get; set; }

        /// <summary>
        /// 默认值：  null
        /// 适用类型:类目型
        /// 小标记是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public object onGap { get; set; }

        /// <summary>
        /// 默认值：  false
        /// 适用类型:通用
        /// 小标记是否显示为在grid内部，默认在外部
        /// </summary>
        public object inside { get; set; }

        /// <summary>
        /// 默认值：5
        /// 适用类型:通用
        /// 属性length控制线长
        /// </summary>
        public object length { get; set; }

        /// <summary>
        /// 默认值：  {
        ///     color: '#333',
        ///     width: 1
        /// }   
        /// 适用类型:通用
        /// （详见lineStyle）属性lineStyle控制线条样式
        /// </summary>
        public object lineStyle { get; set; }

        /// <summary>
        /// 分割段数，控制每份split细分多少段
        /// </summary>
        public int splitNumber { get; set; }
    }
    /// <summary>
    /// 坐标轴文本标签选项
    /// </summary>
    public class AxisLabel
    {
        /// <summary>
        /// 默认值： true
        /// 适用类型:通用
        /// 是否显示，默认为true，设为false后下面都没意义了
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值： 'auto'
        /// 适用类型:类目型
        /// 标签显示挑选间隔，默认为'auto'，可选为： 
        /// 'auto'（自动隐藏显示不下的） | 0（全部显示） | 
        /// {number}（用户指定选择间隔） 
        /// {function}函数回调，传递参数[index，data[index]]，返回true显示，返回false隐藏
        /// </summary>
        public object interval { get; set; }

        /// <summary>
        /// 默认值： 0
        /// 适用类型:通用
        /// 标签旋转角度，默认为0，不旋转，正值为逆时针，负值为顺时针，可选为：-90 ~ 90
        /// </summary>
        public object rotate { get; set; }

        /// <summary>
        /// 默认值： 8
        /// 适用类型:通用
        /// 坐标轴文本标签与坐标轴的间距，默认为8，单位px
        /// </summary>
        public object margin { get; set; }

        /// <summary>
        /// 默认值： false
        /// 适用类型:通用
        /// 坐标轴文本标签是否可点击
        /// </summary>
        public object clickable { get; set; }

        /// <summary>
        /// 默认值： null
        /// 适用类型:通用
        /// 间隔名称格式器：{string}（Template） | {Function}
        /// </summary>
        public object formatter { get; set; }

        /// <summary>
        /// 默认值： {
        ///     color: '#333'
        /// }  
        /// 适用类型:通用
        /// 文本样式（详见textStyle），其中当坐标轴为数值型和时间型时，color接受方法回调，实现个性化的颜色定义，support #226 »
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
    }
    /// <summary>
    /// 分隔线
    /// </summary>
    public class SplitLine
    {
        /// <summary>
        /// 默认值：true
        /// 适用类型:通用
        /// 是否显示，默认为true，设为false后下面都没意义了
        /// </summary>
        public object show { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型:类目型
        /// 分隔线是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public object onGap { get; set; }

        /// <summary>
        /// 默认值：{
        ///     color: ['#ccc'],
        ///     width: 1,
        ///     type: 'solid'
        /// }
        /// 适用类型:通用
        /// （详见lineStyle）属性lineStyle控制线条样式
        /// </summary>
        public ChartLineStyle lineStyle { get; set; }

        /// <summary>
        /// 线长
        /// </summary>
        public object length { get; set; }

    }
    /// <summary>
    /// 分隔区域，默认不显示
    /// </summary>
    public class SplitArea
    {
        /// <summary>
        /// 默认值：false
        /// 适用类型:通用
        /// 是否显示，默认为false，设为true后带如下默认样式
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 默认值：null
        /// 适用类型:类目型
        /// 分隔区域是否显示为间隔，默认等于boundaryGap
        /// </summary>
        public object onGap { get; set; }
        /// <summary>
        /// 默认值：{
        ///     color: [
        ///         'rgba(250,250,250,0.3)',
        ///         'rgba(200,200,200,0.3)'
        ///     ]
        /// }    
        /// 适用类型:通用
        /// 属性areaStyle（详见areaStyle）控制区域样式，颜色数组实现间隔变换。
        /// </summary>
        public object areaStyle { get; set; }
    }
    /// <summary>
    /// 类目型坐标轴文本标签数组，指定label内容。 数组项通常为文本，'\n'指定换行
    /// </summary>
    public class AxisData
    {
        /// <summary>
        /// 值
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// （详见textStyle）值样式
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
    }
}
