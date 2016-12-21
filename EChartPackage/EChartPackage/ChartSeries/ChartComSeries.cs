using System.Collections.Generic;
using EChartPackage.ChartCommon;

namespace EChartPackage.ChartSeries
{
    /// <summary>
    /// 适用类型：通用
    /// 驱动图表生成的数据内容数组，数组中每一项为一个系列的选项及数据，其中个别选项仅在部分图表类型中有效，请注意适用类型
    /// </summary>
    public class ChartComSeries
    {
        /// <summary>
        /// 默认值：0
        /// 适用类型：通用
        /// 一级层叠控制。每一个不同的zlevel将产生一个独立的canvas，相同zlevel的组件或图标将在同一个canvas上渲染。zlevel越高越靠顶层，canvas对象增多会消耗更多的内存和性能，并不建议设置过多的zlevel，大部分情况可以通过二级层叠控制z实现层叠控制。
        /// </summary>
        public object zlevel { get; set; }

        /// <summary>
        /// 默认值：2
        /// 适用类型：通用
        /// 二级层叠控制，同一个canvas（相同zlevel）上z越高约靠顶层。 
        /// </summary>
        public object z { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型：通用
        /// 图表类型，必要参数！如为空或不支持类型，则该系列数据不被显示。可选为：
        ///'line'（折线图） | 'bar'（柱状图） | 'scatter'（散点图） | 'k'（K线图）
        ///'pie'（饼图） | 'radar'（雷达图） | 'chord'（和弦图） | 'force'（力导向布局图） | 'map'（地图） 
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型：通用
        /// 系列名称，如启用legend，该值将被legend.data索引相关 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型：通用
        /// 提示框样式，仅对本系列有效，如不设则用option.tooltip,鼠标悬浮交互时的信息提示 
        /// </summary>
        public object tooltip { get; set; }

        /// <summary>
        /// 默认值：true
        /// 适用类型：通用
        /// 数据图形是否可点击，默认开启，如果没有click事件响应可以关闭 
        /// </summary>
        public object clickable { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型：通用
        /// 图形样式
        /// </summary>
        public ChartItemStyle itemStyle { get; set; }

        /// <summary>
        /// 默认值：[]
        /// 适用类型：通用
        /// 系列中的数据内容数组
        /// </summary>
        public List<object> data { get; set; }

        /// <summary>
        /// 默认值：{}
        /// 适用类型：通用
        /// 系列中的数据标注内容
        /// </summary>
        public markPoint markPoint { get; set; }

        /// <summary>
        /// 默认值：{}
        /// 适用类型：通用
        /// 系列中的数据标线内容
        /// </summary>
        public markLine markLine { get; set; }

    }

    /// <summary>
    /// series序列组的数据
    /// </summary>
    public class ChartSeriesData
    {
        public object name { get; set; }
        public object value { get; set; }
        /// <summary>
        /// 文本样式
        /// 详见 itemStyle，注意力导向图单个节点的 itemStyle 中没有 nodeStyle 的配置项，而是直接使用 normal(emphasis) 下的 color, borderWidth 和 borderColor
        /// </summary>
        public ChartItemStyle itemStyle { get; set; }
    }

    /// <summary>
    /// 系列中的数据标注内容
    /// </summary>
    public class markPoint
    {

        /// <summary>
        /// 默认值：true
        /// 数据图形是否可点击，默认开启，如果没有click事件响应可以关闭 
        /// </summary>
        public object clickable { get; set; }

        /// <summary>
        /// 默认值：'pin'
        /// 标志图形类型，默认自动选择（8种类型循环使用，不显示标志图形可设为'none'），默认循环选择类型有：
        ///'circle' | 'rectangle' | 'triangle' | 'diamond' |
        ///'emptyCircle' | 'emptyRectangle' | 'emptyTriangle' | 'emptyDiamond'
        ///另外，还支持五种更特别的标志图形'heart'（心形）、'droplet'（水滴）、'pin'（标注）、'arrow'（箭头）和'star'（五角星），这并不出现在常规的8类图形中，但无论是在系列级还是数据级上你都可以指定使用，同时，'star' + n（n>=3)可变化出N角星，如指定为'star6'则可以显示6角星
        ///自1.3.5起支持symbol为自定义图片，格式为'image://' + '图片路径'， 如'image://../asset/ico/favicon.png' 
        /// </summary>
        public object symbol { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型：折线图 ，散点图 
        /// 标志图形旋转角度[-180,180]
        /// </summary>
        public object symbolRotate { get; set; }

        /// <summary>
        /// 默认值：false
        /// 是否启动大规模标注模式 
        /// </summary>
        public object large { get; set; }

        /// <summary>
        /// 默认值：{
        ///show: false,
        ///type: 'scale',
        ///loop: true,
        ///period: 15,
        ///scaleSize : 2,
        ///bounceDistance: 10,
        ///color : null,
        ///shadowColor : null,
        ///shadowBlur : 0
        ///}          
        /// 标注图形炫光特效:
        ///show 是否开启，默认关闭
        ///type 特效类型，默认为'scale'（放大），可选还有'bounce'（跳动）
        ///loop 循环动画，默认开启,
        ///period 运动周期，无单位，值越大越慢，默认为15
        ///scaleSize 放大倍数，以markPoint symbolSize为基准，type为scale时有效
        ///bounceDistance 跳动距离，单位为px，type为bounce时有效
        ///color 炫光颜色，默认跟随markPoint itemStyle定义颜色,
        ///shadowColor 光影颜色，默认跟随color
        ///shadowBlur 光影模糊度，默认为0 
        /// </summary>
        public object effect { get; set; }

        /// <summary>
        /// 默认值：{...} 
        /// 标注图形样式属性，同series中的itemStyle
        /// </summary>
        public ChartItemStyle itemStyle { get; set; }

        /// <summary>
        /// 默认值：{} 
        /// 地图特有，标注图形定位坐标，同series中的geoCoord
        /// </summary>
        public object geoCoord { get; set; }

        /// <summary>
        /// 默认值：[]
        /// 标注的数据内容数组
        /// </summary>
        public List<markPointdata> data { get; set; }
    }

    /// <summary>
    /// 标注的数据内容数组，最直接的数据项可直接指定标注位置（x，y）以及相关名称（name）和值（value），在饼图、雷达图、力导、和弦图中基本如下:
    /// data : [
    ///{name: '标注1', value: 100, x: 50, y: 20},
    ///{name: '标注2', value: 200, x: 150, y: 120},
    ///...
    ///]
    /// 在存在直角坐标系的图表如折线、柱形、K线、散点图中，除了通过直接指定位置外，如果希望标注基于直角系的定位，可以通过xAxis，yAxis实现，这两个值都会根据坐标轴类型以及传入参数的不同自动换算如下：
    /// data : [
    ///{name: '标注1', value: 100, xAxis: 1, yAxis: 20},      // 当xAxis为类目轴时，数值1会被理解为类目轴的index
    ///{name: '标注2', value: 100, xAxis: '周三', yAxis: 20}, // 当xAxis为类目轴时，字符串'周三'会被理解为与类目轴的文本进行匹配
    ///{name: '标注3', value: 200, xAxis: 10, yAxis: 20},     // 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
    /// ...
    ///]
    /// 更为实用的，在折线、柱形、散点图中，可以直接使用如下几个开箱即用的特殊点标注
    /// data : [
    ///{type : 'max', name: '自定义名字'},    // 最大值
    ///{type : 'min', name: '自定义名字'}     // 最小值
    ///]
    /// 标注数据比较特殊也最为常用的地图上，除了直接位置定位外，如果希望基于地理坐标标注，并且能够随地图漫游缩放，需要为markPoint提供一份geoCoord，如下
    /// data : [
    ///{name: '北京', value: 100},
    ///{name: '上海', value: 200},
    ///...
    ///],
    ///geoCoord : {
    ///"北京":[116.46,39.92],           // 支持数组[经度，维度]
    ///"上海": {x: 121.48, y: 31.22},   // 支持对象{x:经度,y:纬度}
    /// ...
    ///}
    /// </summary>
    public class markPointdata
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public object value { get; set; }

        /// <summary>
        /// 标注类型
        /// min:最小值
        /// max：最大值
        /// </summary>
        public object type { get; set; }

        /// <summary>
        /// 标注X轴位置
        /// </summary>
        public object x { get; set; }

        /// <summary>
        /// 标注Y轴位置
        /// </summary>
        public object y { get; set; }

        /// <summary>
        /// 标注基于直角系X轴的定位
        /// </summary>
        public object xAxis { get; set; }

        /// <summary>
        /// 标注基于直角系Y轴的定位
        /// </summary>
        public object yAxis { get; set; }

        /// <summary>
        /// 标注图形大小，可计算特性启用情况建议增大以提高交互体验。实现气泡图时symbolSize需为Function，气泡大小取决于该方法返回值，传入参数为当前数据项（value数组）
        /// </summary>
        public object symbolSize { get; set; }

    }

    /// <summary>
    /// 系列中的数据标线内容
    /// </summary>
    public class markLine
    {

        /// <summary>
        /// 默认值：true
        /// 数据图形是否可点击，默认开启，如果没有click事件响应可以关闭 
        /// </summary>
        public object clickable { get; set; }

        /// <summary>
        /// 默认值：['circle', 'arrow'] 
        /// 标线起始和结束的symbol介绍类型，如果都一样，可以直接传string，同series中的symbol
        /// </summary>
        public string[] symbol { get; set; }

        /// <summary>
        /// 默认值：[2, 4] 
        /// 标线起始和结束的symbol大小，半宽（半径）参数，如果都一样，可以直接传number或function，同series中的symbolSize
        /// </summary>
        public object symbolSize { get; set; }

        /// <summary>
        /// 默认值：null
        /// 适用类型：折线图 ，散点图 
        /// 标志图形旋转角度[-180,180]
        /// </summary>
        public object symbolRotate { get; set; }

        /// <summary>
        /// 默认值：false
        /// 是否启用大规模标线模式，默认关闭。
        ///大规模标线模式下会优化标线绘制，同个系列的的所有标线都会使用同一种样式，并且忽略标线两端 symbol 的绘制。 
        /// </summary>
        public object large { get; set; }

        /// <summary>
        /// 默认值：false
        /// 平滑曲线显示，smooth为true时lineStyle不支持虚线
        /// </summary>
        public object smooth { get; set; }

        /// <summary>
        /// 默认值：0.2
        /// 平滑曲线弧度，smooth为true时有效，指定平滑曲线弧度
        /// </summary>
        public object smoothness { get; set; }

        /// <summary>
        /// 默认值：2
        /// 小数精度，使用开箱即用的均线markLine时有效
        /// </summary>
        public object precision { get; set; }

        /// <summary>
        /// 边捆绑：
        ///enable 是否使用边捆绑，默认关闭
        ///maxTurningAngle 边捆绑算法参数，可选 [0, 90] 的角度，配置捆绑后的边最大拐角, 默认为 45 度
        ///注：捆绑算法使用 Multilevel Agglomerative Edge Bundling for Visualizing Large Graphs 
        /// 默认值：
        /// {
        ///enable: false,
        ///maxTurningAngle: 45
        ///}
        /// </summary>
        public object bundling { get; set; }

        /// <summary>
        /// 标线图形炫光特效:
        ///show 是否开启，默认关闭
        ///loop 循环动画，默认开启,
        ///period 运动周期，无单位，值越大越慢，默认为15
        ///scaleSize 放大倍数，以markLine lineWidth为基准
        ///color 炫光颜色，默认跟随markLine itemStyle定义颜色,
        ///shadowColor 光影颜色，默认跟随color
        ///shadowBlur 光影模糊度，默认根据scaleSize计算 
        /// {
        ///show: false,
        ///loop: true,
        ///period: 15,
        ///scaleSize : 2,
        ///color : null,
        ///shadowColor : null,
        ///shadowBlur : null
        ///}           
        /// </summary>
        public object effect { get; set; }

        /// <summary>
        /// 标线图形样式属性，同series中的itemStyle
        /// </summary>
        public ChartItemStyle itemStyle { get; set; }

        /// <summary>
        /// 地图特有，标线图形定位坐标，同series中的geoCoord
        /// </summary>
        public object geoCoord { get; set; }

        /// <summary>
        /// 标注图形数据
        /// </summary>
        public List<markLinedata> data { get; set; }
    }


    /// <summary>
    /// 标线的数据内容数组，最直接的数据项可直接指定标线起始和结束位置（x，y）以及相关名称（name）和值（value），在饼图、雷达图、力导、和弦图中基本如下:
    /// data : [
    ///[
    ///    {name: '标线1起点', value: 100, x: 50, y: 20}, 
    ///    {name: '标线1终点', x: 150, y: 120}
    ///],
    ///[
    ///    {name: '标线2起点', value: 200, x: 30, y: 80}, 
    ///    {name: '标线2终点', x: 270, y: 190}
    ///],
    ///...
    ///]
    /// 在存在直角坐标系的图表如折线、柱形、K线、散点图中，除了通过直接指定位置外，如果希望标线基于直角系的定位，可以通过xAxis，yAxis实现，这两个值都会根据坐标轴类型以及传入参数的不同自动换算如下：
    /// data : [
    ///[
    ///    {name: '标线1起点', value: 100, xAxis: 1, yAxis: 20},      // 当xAxis为类目轴时，数值1会被理解为类目轴的index，通过xAxis:-1|MAXNUMBER可以让线到达grid边缘
    ///    {name: '标线1终点', xAxis: '周三', yAxis: 20},             // 当xAxis为类目轴时，字符串'周三'会被理解为与类目轴的文本进行匹配
    ///],
    ///[
    ///    {name: '标线2起点', value: 200, xAxis: 10, yAxis: 20},     // 当xAxis或yAxis为数值轴时，不管传入是什么，都被理解为数值后做空间位置换算
    ///    {name: '标线2终点', xAxis: 270, yAxis: 190}
    ///],
    ///...
    ///]
    /// 更为实用的，在折线、柱形、散点图中，可以直接使用如下几个开箱即用的特殊点作为标线类型
    /// data : [
    ///{type : 'max', name: '自定义名字'},    // 最大值水平线或垂直线
    ///{type : 'min', name: '自定义名字'},    // 最小值水平线或垂直线
    ///{type : 'average', name: '自定义名字'},// 平均值水平线或垂直线
    ///
    /// 最小值指向最大值的连线
    ///[
    ///    {type : 'min', name: '自定义名字'},
    ///    {type : 'max', name: '自定义名字'}
    ///],
    ///
    /// 散点图中存在两个数值型坐标，默认用纵轴值计算特殊点，可以通过valueIndex:0指定为横轴特殊点
    ///{type : 'max', name: '自定义名字', valueIndex:0} 
    ///]
    /// </summary>
    public class markLinedata
    {
        /// <summary>
        /// 数据标线名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 数据标线值
        /// </summary>
        public string value { get; set; }

        /// <summary>
        /// 水平线或垂直线类型
        /// max:最大值水平线或垂直线
        /// min:最小值水平线或垂直线
        /// average:平均值水平线或垂直线
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 数据标线起始位置
        /// </summary>
        public object x { get; set; }

        /// <summary>
        /// 数据标线结束位置
        /// </summary>
        public object y { get; set; }

        /// <summary>
        /// 数据标线基于直角系X轴的定位
        /// </summary>
        public object xAxis { get; set; }

        /// <summary>
        /// 数据标线基于直角系Y轴的定位
        /// </summary>
        public object yAxis { get; set; }
    }

}
