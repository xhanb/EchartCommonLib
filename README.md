# EchartCommonLib
    基于Echart的封装类库，为Echart前端各类图表展示提供封装好的数据格式（兼容2.0及3.0）。
##使用方式
    1.在你的项目中引用该类库及其相关dll；
    2.调用各类图表数据处理方法，包括饼状图（方法名称ChartPieDataProcess）、线性图（方法名称ChartLineDataProcess）、时间轴线性图（方法名称       TimeLineChartLineDataProcess）、柱状图（方法名称ChartBarDataProcess）、折柱混搭（方法名称ChartBarAndLineDataProcess）、条形图（方法名称ChartTiaoBarDataProcess）、多维条形图（方法名称ChartDuoWeiTiaoBarDataProcess），然后根据相应的方法使用相关的图表类型拼组你想要的数据格式后进行传参。
    3.在前端将Echart进行初始化（不同版本初始化方式不同）后,赋值处理好的json数据给相应的图表。
