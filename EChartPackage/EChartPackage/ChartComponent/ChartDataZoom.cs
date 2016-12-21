namespace EChartPackage.ChartComponent
{
    /// <summary>
    /// 数据区域缩放。与toolbox.feature.dataZoom同步，仅对直角坐标系图表有效。
    /// </summary>
    public class ChartDataZoom
    {
        /// <summary>
        /// 默认值：0
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public int zlevel { get; set; }
        /// <summary>
        /// 默认值：4
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。
        /// </summary>
        public int z { get; set; }
        /// <summary>
        /// 默认值：false
        /// 是否显示，当show为true时则接管使用指定类目轴的全部系列数据，如不指定则接管全部直角坐标系数据。
        /// </summary>
        public bool show { get; set; }
        /// <summary>
        /// 默认值：'horizontal'
        /// 布局方式，默认为水平布局，可选为：'horizontal' | 'vertical'
        /// </summary>
        public string orient { get; set; }
        /// <summary>
        /// 默认值：自适应
        /// 水平安放位置，默认为根据grid参数适配，纵向布局默认左侧，可指定 {number}（左上角x坐标，单位px）
        /// </summary>
        public object x { get; set; }
        /// <summary>
        /// 默认值：自适应
        /// 垂直安放位置，默认为根据grid参数适配，纵向布局默认下方，可指定 {number}（左上角y坐标，单位px）
        /// </summary>
        public object y { get; set; }
        /// <summary>
        /// 默认值：自适应 | 30
        /// 指定宽度，横向布局时默认为根据grid参数适配，纵向布局是默认为30，可指定 {number}（宽度，单位px）
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// 默认值：自适应 | 30
        /// 指定高度，纵向布局时默认为根据grid参数适配，横向布局是默认为30，可指定 {number}（高度，单位px）
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 默认值：'rgba(0,0,0,0)'
        /// 背景颜色，默认透明
        /// </summary>
        public string backgroundColor { get; set; }
        /// <summary>
        /// 默认值：'#eee'
        /// 数据缩略背景颜色，仅以第一个系列的数据作为缩量图显示
        /// </summary>
        public string dataBackgroundColor { get; set; }
        /// <summary>
        /// 默认值：'rgba(144,197,237,0.2)'
        /// 选择区域填充颜色
        /// </summary>
        public string fillerColor { get; set; }
        /// <summary>
        /// 默认值：'rgba(70,130,180,0.8)'
        /// 控制手柄颜色
        /// </summary>
        public string handleColor { get; set; }
        /// <summary>
        /// 默认值：8
        /// 控制手柄大小
        /// </summary>
        public int handleSize { get; set; }
        /// <summary>
        /// 默认值：null
        /// 当不指定时默认控制所有横向类目，可通过数组指定多个需要控制的横向类目坐标轴Index，仅一个时可直接为数字
        /// </summary>
        public object xAxisIndex { get; set; }
        /// <summary>
        /// 默认值：null
        /// 当不指定时默认控制所有纵向类目，可通过数组指定多个需要控制的纵向类目坐标轴Index，仅一个时可直接为数字
        /// </summary>
        public object yAxisIndex { get; set; }
        /// <summary>
        /// 默认值：0
        /// 数据缩放，选择起始比例，默认为0（%），从首个数据起选择。
        /// </summary>
        public int start { get; set; }
        /// <summary>
        /// 默认值：100
        /// 数据缩放，选择结束比例，默认为100（%），到最后一个数据选择结束。
        /// </summary>
        public int end { get; set; }
        /// <summary>
        /// 默认值：true
        /// 缩放变化是否显示定位详情。
        /// </summary>
        public bool showDetail { get; set; }
        /// <summary>
        /// 默认值：false
        /// 缩放变化是否实时显示，在不支持Canvas的浏览器中该值自动强制置为false。
        /// </summary>
        public bool realtime { get; set; }
        /// <summary>
        /// 默认值：false
        /// 数据缩放锁，默认为false，当设置为true时选择区域不能伸缩，即(end - start)值保持不变，仅能做数据漫游。
        /// </summary>
        public bool zoomLock { get; set; }
    }
}
