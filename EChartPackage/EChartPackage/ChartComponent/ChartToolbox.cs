using EChartPackage.ChartCommon;

namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 工具箱，每个图表最多仅有一个工具箱
    /// </summary>
    public class ChartToolbox
    {
        /// <summary>
        /// 默认值：false	
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 默认值：0
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public object zlevel { get; set; }
        /// <summary>
        /// 默认值：6
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public object z { get; set; }
        /// <summary>
        /// 默认值：'horizontal'
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public string orient { get; set; }
        /// <summary>
        /// 默认值：'right'
        /// 水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right' | {number}（x坐标，单位px）
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值：'top'
        /// 垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center' | {number}（y坐标，单位px）
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0)'
        /// 工具箱背景颜色，默认透明
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值：'#ccc'
        /// 工具箱边框颜色
        /// </summary>
        public string borderColor { get; set; }
        /// <summary>
        /// 默认值：0
        /// 工具箱边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public object borderWidth { get; set; }
        /// <summary>
        /// 默认值：5
        /// 工具箱内边距，单位px，默认各方向内边距为5，接受数组分别设定上右下左边距，同css，见下图
        /// </summary>
        public object padding { get; set; }
        /// <summary>
        /// 默认值：10
        /// 各个item之间的间隔，单位px，默认为10，横向布局时为水平间隔，纵向布局时为纵向间隔，见下图
        /// </summary>
        public object itemGap { get; set; }
        /// <summary>
        /// 默认值：16
        /// 工具箱icon大小，单位（px）
        /// </summary>
        public object itemSize { get; set; }
        /// <summary>
        /// 默认值：['#1e90ff','#22bb22','#4b0082','#d2691e']
        /// 工具箱icon颜色序列，循环使用，同时支持在具体feature内指定color
        /// </summary>
        public string[] color { get; set; }
        /// <summary>
        /// 默认值：'#ddd'
        /// 禁用颜色定义
        /// </summary>
        public string disableColor { get; set; }
        /// <summary>
        /// 默认值：'red'
        /// 生效颜色定义
        /// </summary>
        public string effectiveColor { get; set; }
        /// <summary>
        /// 默认值：true
        /// 是否显示工具箱文字提示，默认启用
        /// </summary>
        public object showTitle { get; set; }
        /// <summary>
        /// 默认值：{}
        /// 工具箱提示文字样式，（详见textStyle）
        /// </summary>
        public ChartTextStyle textStyle { get; set; }
        /// <summary>
        /// 默认值：{
        ///     mark : {
        ///         show : false,
        ///         title : {
        ///             mark : '辅助线开关',
        ///             markUndo : '删除辅助线',
        ///             markClear : '清空辅助线'
        ///         },
        ///         lineStyle : {
        ///             width : 2,
        ///             color : '#1e90ff',
        ///             type : 'dashed'
        ///         }
        ///     },
        ///     dataZoom : {
        ///         show : false,
        ///         title : {
        ///             dataZoom : '区域缩放',
        ///             dataZoomReset : '区域缩放后退'
        ///         }
        ///     },
        ///     dataView : {
        ///         show : false,
        ///         title : '数据视图',
        ///         readOnly: false,
        ///         lang: ['数据视图', '关闭', '刷新']
        ///     },
        ///     magicType: {
        ///         show : false,
        ///         title : {
        ///             line : '折线图切换',
        ///             bar : '柱形图切换',
        ///             stack : '堆积',
        ///             tiled : '平铺',
        ///             force: '力导向布局图切换',
        ///             chord: '和弦图切换',
        ///             pie: '饼图切换',
        ///             funnel: '漏斗图切换'
        ///         },
        ///         option: {
        ///             // line: {...},
        ///             // bar: {...},
        ///             // stack: {...},
        ///             // tiled: {...},
        ///             // force: {...},
        ///             // chord: {...},
        ///             // pie: {...},
        ///             // funnel: {...}
        ///         },
        ///         type : []
        ///     },
        ///     restore : {
        ///         show : false,
        ///         title : '还原'
        ///     },
        ///     saveAsImage : {
        ///         show : false,
        ///         title : '保存为图片',
        ///         type : 'png',
        ///         lang : ['点击保存'] 
        ///     }
        /// } 
        /// 启用功能，目前支持feature见下，工具箱自定义功能回调处理
        /// mark，辅助线标志，上图icon左数1/2/3，分别是启用，删除上一条，删除全部，可设置更多属性
        /// 可传入lineStyle（详见lineStyle）控制线条样式
        /// 
        /// dataZoom，框选区域缩放，自动与存在的dataZoom控件同步，上图icon左数4/5，分别是启用，缩放后退
        /// 
        /// dataView，数据视图，上图icon左数6，打开数据视图，可设置更多属性
        /// {boolean=} readOnly 默认数据视图为只读，可指定readOnly为false打开编辑功能
        /// {Function=} optionToContent 自主编排数据视图的显示内容
        /// {Function=} contentToOption 当数据视图readOnly为false时，会出现刷新按钮，如果是自主编排的显示内容，如何翻转也请自理
        /// {Array=} lang 数据视图上有三个话术，默认是['数据视图', '关闭', '刷新']，如需改写，可自定义
        /// 
        /// magicType，动态类型切换，支持直角系下的折线图、柱状图、堆积、平铺转换，上图icon左数6~14，分别是切换为堆积，切换为平铺，切换折线图，切换柱形图，切换为力导向布局图，切换为和弦图，切换为饼图，切换为漏斗图
        /// {Array} type ['line', 'bar', 'stack', 'tiled', 'force', 'chord', 'pie', 'funnel']
        /// {Object=} option 可选，可传入切换是动态修改的配置，将复写series内的数组项
        /// 
        /// restore，还原，复位原始图表，上图icon右数2
        /// 
        /// saveAsImage，保存图片（IE8-不支持），上图icon最右，可设置更多属性
        /// {string=} type 默认保存图片类型为'png'，需改为'jpeg'
        /// {string=} name 指定图片名称，如不指定，则用图表title标题，如无title标题则图片名称默认为“ECharts”
        /// {string=} lang 非IE浏览器支持点击下载，有保存话术，默认是“点击保存”，可修改
        /// </summary>
        public Feature feature { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class Feature
    {
        /// <summary>
        /// mark，辅助线标志，上图icon左数1/2/3，分别是启用，删除上一条，删除全部，可设置更多属性
        /// </summary>
        public Mark mark { get; set; }
        /// <summary>
        /// dataZoom，框选区域缩放，自动与存在的dataZoom控件同步，上图icon左数4/5，分别是启用，缩放后退
        /// </summary>
        public DataZoom dataZoom { get; set; }
        /// <summary>
        /// dataView，数据视图，上图icon左数6，打开数据视图，可设置更多属性
        /// </summary>
        public DataView dataView { get; set; }
        /// <summary>
        /// magicType，动态类型切换，支持直角系下的折线图、柱状图、堆积、平铺转换，上图icon左数6~14，分别是切换为堆积，切换为平铺，切换折线图，切换柱形图，切换为力导向布局图，切换为和弦图，切换为饼图，切换为漏斗图
        /// </summary>
        public MagicType magicType { get; set; }
        /// <summary>
        /// restore，还原，复位原始图表，上图icon右数2
        /// </summary>
        public Restore restore { get; set; }
        /// <summary>
        /// saveAsImage，保存图片（IE8-不支持），上图icon最右，可设置更多属性
        /// </summary>
        public SaveAsImage saveAsImage { get; set; }
    }
    /// <summary>
    /// mark，辅助线标志，上图icon左数1/2/3，分别是启用，删除上一条，删除全部，可设置更多属性
    /// 可传入lineStyle（详见lineStyle）控制线条样式
    /// </summary>
    public class Mark
    {
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 辅助线
        /// </summary>
        public MarkTitle title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ChartLineStyle lineStyle { get; set; }
    }
    /// <summary>
    /// 辅助线
    /// </summary>
    public class MarkTitle
    {
        /// <summary>
        /// 辅助线开关
        /// </summary>
        public string mark { get; set; }
        /// <summary>
        /// 删除辅助线
        /// </summary>
        public string markUndo { get; set; }
        /// <summary>
        /// 清空辅助线
        /// </summary>
        public string markClear { get; set; }
    }
    /// <summary>
    /// dataZoom，框选区域缩放，自动与存在的dataZoom控件同步，上图icon左数4/5，分别是启用，缩放后退
    /// </summary>
    public class DataZoom
    {
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 区域缩放
        /// </summary>
        public DataZoomTitle title { get; set; }
    }
    /// <summary>
    /// 区域缩放
    /// </summary>
    public class DataZoomTitle
    {
        /// <summary>
        /// 区域缩放
        /// </summary>
        public string dataZoom { get; set; }
        /// <summary>
        /// 区域缩放后退
        /// </summary>
        public string dataZoomReset { get; set; }
    }

    /// <summary>
    /// dataView，数据视图，上图icon左数6，打开数据视图，可设置更多属性
    /// {boolean=} readOnly 默认数据视图为只读，可指定readOnly为false打开编辑功能
    /// {Function=} optionToContent 自主编排数据视图的显示内容
    /// {Function=} contentToOption 当数据视图readOnly为false时，会出现刷新按钮，如果是自主编排的显示内容，如何翻转也请自理
    /// {Array=} lang 数据视图上有三个话术，默认是['数据视图', '关闭', '刷新']，如需改写，可自定义
    /// </summary>
    public class DataView
    {
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 数据视图
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object readOnly { get; set; }
        /// <summary>
        ///  ['数据视图', '关闭', '刷新']
        /// </summary>
        public string[] lang { get; set; }
    }
    /// <summary>
    /// magicType，动态类型切换，支持直角系下的折线图、柱状图、堆积、平铺转换，上图icon左数6~14，分别是切换为堆积，切换为平铺，切换折线图，切换柱形图，切换为力导向布局图，切换为和弦图，切换为饼图，切换为漏斗图
    /// {Array} type ['line', 'bar', 'stack', 'tiled', 'force', 'chord', 'pie', 'funnel']
    /// {Object=} option 可选，可传入切换是动态修改的配置，将复写series内的数组项
    /// </summary>
    public class MagicType
    {
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// 图切换
        /// </summary>
        public MagicTypeTitle title { get; set; }
        /// <summary>
        /// ['line', 'bar', 'stack', 'tiled', 'force', 'chord', 'pie', 'funnel']
        /// </summary>
        public string[] type { get; set; }
    }
    /// <summary>
    /// 图切换
    /// </summary>
    public class MagicTypeTitle
    {
        /// <summary>
        /// '折线图切换'
        /// </summary>
        public string line { get; set; }
        /// <summary>
        /// '柱形图切换'
        /// </summary>
        public string bar { get; set; }
        /// <summary>
        /// '堆积'
        /// </summary>
        public string stack { get; set; }
        /// <summary>
        /// '平铺'
        /// </summary>
        public string tiled { get; set; }
        /// <summary>
        /// '力导向布局图切换'
        /// </summary>
        public string force { get; set; }
        /// <summary>
        /// '和弦图切换'
        /// </summary>
        public string chord { get; set; }
        /// <summary>
        /// '饼图切换'
        /// </summary>
        public string pie { get; set; }
        /// <summary>
        /// '漏斗图切换'
        /// </summary>
        public string funnel { get; set; }
    }
    /// <summary>
    /// restore，还原，复位原始图表，上图icon右数2
    /// </summary>
    public class Restore
    {
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// '还原'
        /// </summary>
        public string title { get; set; }
    }
    /// <summary>
    /// saveAsImage，保存图片（IE8-不支持），上图icon最右，可设置更多属性
    /// {string=} type 默认保存图片类型为'png'，需改为'jpeg'
    /// {string=} name 指定图片名称，如不指定，则用图表title标题，如无title标题则图片名称默认为“ECharts”
    /// {string=} lang 非IE浏览器支持点击下载，有保存话术，默认是“点击保存”，可修改
    /// </summary>
    public class SaveAsImage
    {
        /// <summary>
        /// 显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public object show { get; set; }
        /// <summary>
        /// '保存为图片'
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 'png'
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// ['点击保存'] 
        /// </summary>
        public string lang { get; set; }
    }
}
