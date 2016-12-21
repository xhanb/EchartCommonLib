/* ==============================
*
* Author: 高海波
* FileName：ChartOpertation
* 说明:图表操作数据处理类
* ===============================
*/

using System.Collections.Generic;
using EChartPackage.ChartCommon;
using EChartPackage.ChartComponent;
using EChartPackage.ChartSeries;

namespace EchartLib
{
    /// <summary>
    /// 图表操作数据处理类
    /// </summary>
    public static class ChartOpertation
    {
        /// <summary>
        /// 饼状图数据处理
        /// </summary>
        /// <param name="lengendData">图例数据</param>
        /// <param name="seriesData">图表数据</param>
        /// <param name="isShowlengend">是否开启图例</param>
        /// <param name="charttitle">主标题文本，默认值：''，'\n'指定换行</param>
        /// <param name="chatsubtitle"> 副标题文本，默认值：''，'\n'指定换行</param>
        /// <param name="isCalculable"> 是否启用拖拽重计算特性，默认关闭</param>
        /// <returns></returns>
        public static string ChartPieDataProcess(IEnumerable<ChartPieSeries> seriesData, List<string> lengendData, bool isShowlengend = false, string charttitle = null, string chatsubtitle = null, bool isCalculable = false)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle,
                textStyle = new ChartTextStyle() { fontSize = 20, fontWeight = "bolder", color = "#333" },
                x = "center",
                y = "center"
            };
            //提示框
            var chartTooltip = new ChartTooltip() { trigger = "item", formatter = "{a} <br/>{b} : {d}%" };
            //图例
            var chartLegend = new ChartLegend() { show = isShowlengend, data = lengendData };

            //数据
            var chartPieSeries = new List<ChartPieSeries>();
            chartPieSeries.AddRange(seriesData);
            var seriesDatas = chartPieSeries.Count > 0 ? chartPieSeries : (object)"-";

            var jsondata = new
            {
                title = chartTitle,
                tooltip = chartTooltip,
                calculable = isCalculable,
                legend = chartLegend,
                series = seriesDatas
            };
            return jsondata.ToJson();
        }

        /// <summary>
        /// 线性图数据处理
        /// </summary>
        /// <param name="charttitle">标题</param>
        /// <param name="fm">y轴数据自定义单位，如“元”，“年”</param>
        /// <param name="chartAxisData">坐标轴数据</param>
        /// <param name="seriesData">图表数据</param>
        /// <param name="lengendData">图例数据</param>
        /// <param name="isShowlengend">是否开启图例</param>
        /// <param name="chatsubtitle">副标题文本，默认值：""，"\n"指定换行</param>
        /// <param name="isCalculable">是否启用拖拽重计算特性，默认关闭</param>
        /// <param name="chartYAxisName">Y轴名称</param>
        /// <returns>图表所有数据</returns>
        public static string ChartLineDataProcess(string charttitle, string fm, List<object> chartAxisData, IEnumerable<ChartRightangleSeries> seriesData, List<string> lengendData, bool isShowlengend = false, string chatsubtitle = null, bool isCalculable = false, string chartYAxisName = null)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle
            };
            //提示框
            var chartTooltip = new ChartTooltip() { trigger = "axis" };
            //图例
            var chartLegend = new ChartLegend() { show = isShowlengend, data = lengendData };

            //X坐标轴
            var chartXAxis = new List<ChartAxis>()
            {
               new ChartAxis
               {
                   type = "category",
                   boundaryGap = false,
                   data = chartAxisData
               }
            };

            //Y坐标轴
            var chartYAxis = new List<ChartAxis>()
            {
                    new ChartAxis()
                    {
                        type = "value",
                        name=chartYAxisName,
                        axisLabel=new AxisLabel(){formatter="{value} "+fm}
                    }
            };

            //数据
            var chartRightangleSeries = new List<ChartRightangleSeries>();
            chartRightangleSeries.AddRange(seriesData);
            var seriesDatas = chartRightangleSeries.Count > 0 ? chartRightangleSeries : (object)"-";

            var jsondata = new
            {
                title = chartTitle,
                tooltip = chartTooltip,
                calculable = isCalculable,
                legend = chartLegend,
                xAxis = chartXAxis,
                yAxis = chartYAxis,
                series = seriesDatas
            };
            return jsondata.ToJson();
        }

        /// <summary>
        /// 时间轴线性图数据处理
        /// </summary>
        /// <param name="charttitle">标题</param>
        /// <param name="fm">y轴数据自定义单位，如“元”，“年”</param>
        /// <param name="chartAxisData">坐标轴数据</param>
        /// <param name="seriesData">图表数据</param>
        /// <param name="lengendData">图例数据</param>
        /// <param name="isShowlengend">是否开启图例</param>
        /// <param name="chatsubtitle">副标题文本，默认值：""，"\n"指定换行</param>
        /// <param name="isCalculable">是否启用拖拽重计算特性，默认关闭</param>
        /// <param name="chartYAxisName">Y轴名称</param>
        /// <param name="chartTimeline">时间轴</param>
        /// <returns>图表所有数据</returns>
        public static string TimeLineChartLineDataProcess(string charttitle, string fm, List<object> chartAxisData, IEnumerable<ChartRightangleSeries> seriesData, List<string> lengendData, bool isShowlengend = false, string chatsubtitle = null, bool isCalculable = false, string chartYAxisName = null, ChartTimeline chartTimeline = null)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle
            };
            //提示框
            var chartTooltip = new ChartTooltip() { trigger = "axis" };
            //图例
            var chartLegend = new ChartLegend() { show = isShowlengend, data = lengendData };

            //X坐标轴
            var chartXAxis = new List<ChartAxis>()
            {
               new ChartAxis
               {
                   type = "category",
                   boundaryGap = false,
                   data = chartAxisData
               }
            };

            //Y坐标轴
            var chartYAxis = new List<ChartAxis>()
            {
                    new ChartAxis()
                    {
                        type = "value",
                        name=chartYAxisName
                    }
            };

            //数据
            var chartRightangleSeries = new List<ChartRightangleSeries>();
            chartRightangleSeries.AddRange(seriesData);
            var seriesDatas = chartRightangleSeries.Count > 0 ? chartRightangleSeries : (object)"-";

            //时间点
            var chartOptions = new List<object> { new { chartTitle, chartTooltip, chartXAxis, chartYAxis, series = seriesDatas } };

            var jsondata = new
            {
                timeline = chartTimeline,//时间轴设置
                options = chartOptions
            };
            return jsondata.ToJson();
        }

        /// <summary>
        /// 柱状图数据处理
        /// </summary>
        /// <param name="charttitle">标题</param>
        /// <param name="chartAxisData">坐标轴数据</param>
        /// <param name="seriesData">图表数据</param>
        /// <param name="lengendData">图例数据</param>
        /// <param name="chartGrid">直角坐标系内绘图网格</param>
        /// <param name="isShowlengend">是否开启图例</param>
        /// <param name="chatsubtitle">副标题文本，默认值：''，'\n'指定换行</param>
        /// <param name="isCalculable">是否启用拖拽重计算特性，默认关闭</param>
        /// <param name="chartYAxisName">Y轴名称</param>
        /// <returns>图表所有数据</returns>
        public static string ChartBarDataProcess(string charttitle, List<object> chartAxisData, IEnumerable<ChartRightangleSeries> seriesData, List<string> lengendData, ChartGrid chartGrid, bool isShowlengend = false, string chatsubtitle = null, bool isCalculable = false, string chartYAxisName = null)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle
            };
            //提示框
            var chartTooltip = new ChartTooltip() { trigger = "axis" };
            //图例
            var chartLegend = new ChartLegend() { show = isShowlengend, data = lengendData };

            //X坐标轴
            var chartXAxis = new List<ChartAxis>()
            {
               new ChartAxis
               {
                   type = "category",
                   data = chartAxisData
               }
            };

            //Y坐标轴
            var chartYAxis = new List<ChartAxis>()
            {
                    new ChartAxis()
                    {
                        type = "value",
                        name = chartYAxisName

                    }
            };

            //数据
            var chartRightangleSeries = new List<ChartRightangleSeries>();
            chartRightangleSeries.AddRange(seriesData);
            var seriesDatas = chartRightangleSeries.Count > 0 ? chartRightangleSeries : (object)"-";

            var jsondata = new
            {
                title = chartTitle,
                tooltip = chartTooltip,
                calculable = isCalculable,
                legend = chartLegend,
                grid = chartGrid,
                xAxis = chartXAxis,
                yAxis = chartYAxis,
                series = seriesDatas
            };
            return jsondata.ToJson();
        }

        /// <summary>
        /// 折柱混搭
        /// </summary>
        /// <param name="charttitle"></param>
        /// <param name="chartAxisData"></param>
        /// <param name="seriesData"></param>
        /// <param name="lengendData"></param>
        /// <param name="chartYaxis"></param>
        /// <param name="chartGrid"></param>
        /// <param name="isShowlengend"></param>
        /// <param name="chatsubtitle"></param>
        /// <param name="isCalculable"></param>
        /// <returns></returns>
        public static string ChartBarAndLineDataProcess(string charttitle, List<object> chartAxisData, IEnumerable<ChartRightangleSeries> seriesData, List<string> lengendData, List<ChartAxis> chartYaxis, ChartGrid chartGrid, bool isShowlengend = false, string chatsubtitle = null, bool isCalculable = false)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle
            };
            //提示框
            var chartTooltip = new ChartTooltip() { trigger = "axis" };
            //图例
            var chartLegend = new ChartLegend() { show = isShowlengend, data = lengendData };

            //X坐标轴
            var chartXAxis = new List<ChartAxis>()
            {
               new ChartAxis
               {
                   type = "category",
                   data = chartAxisData
               }
            };

            //Y坐标轴
            var chartYAxis = chartYaxis;

            //数据
            var chartRightangleSeries = new List<ChartRightangleSeries>();
            chartRightangleSeries.AddRange(seriesData);
            var seriesDatas = chartRightangleSeries.Count > 0 ? chartRightangleSeries : (object)"-";

            var jsondata = new
            {
                title = chartTitle,
                tooltip = chartTooltip,
                calculable = isCalculable,
                legend = chartLegend,
                grid = chartGrid,
                xAxis = chartXAxis,
                yAxis = chartYAxis,
                series = seriesDatas
            };
            return jsondata.ToJson();
        }


        /// <summary>
        /// 条形图数据处理
        /// </summary>
        /// <param name="charttitle">标题</param>
        /// <param name="chartAxisData">坐标轴数据</param>
        /// <param name="seriesData">图表数据</param>
        /// <param name="lengendData">图例数据</param>
        /// <param name="chartGrid">直角坐标系内绘图网格</param>
        /// <param name="isShowX">X轴是否显示</param>
        /// <param name="isShowY">Y轴是否显示</param>
        /// <param name="isShowlengend">是否开启图例</param>
        /// <param name="chatsubtitle">副标题文本，默认值：''，'\n'指定换行</param>
        /// <param name="isCalculable">是否启用拖拽重计算特性，默认关闭</param>
        /// <returns>图表所有数据</returns>
        public static string ChartTiaoBarDataProcess(string charttitle, List<object> chartAxisData, IEnumerable<ChartRightangleSeries> seriesData, List<string> lengendData, ChartGrid chartGrid, bool isShowX = false, bool isShowY = true, bool isShowlengend = false, string chatsubtitle = null, bool isCalculable = false, bool isShowY1AxisTick = false, bool isShowY1AxisLine = false)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle
            };
            //提示框
            var chartTooltip = new ChartTooltip() { trigger = "axis" };
            //图例
            var chartLegend = new ChartLegend() { show = isShowlengend, data = lengendData };

            //X坐标轴
            var chartXAxis = new List<ChartAxis>()
            {
               new ChartAxis
               {
                   type = "value",
                   show=isShowX,
                   boundaryGap =new List<object>(){0,0}
               }
            };

            //Y坐标轴
            var chartYAxis = new List<ChartAxis>()
            {
                    new ChartAxis()
                    {
                        type = "category",
                        axisTick=new AxisTick(){show = isShowY1AxisTick},
                        axisLine=new AxisLine(){show = isShowY1AxisLine},
                        show=isShowY,
                        data = chartAxisData
                    }
            };

            //数据
            var chartRightangleSeries = new List<ChartRightangleSeries>();
            chartRightangleSeries.AddRange(seriesData);
            var seriesDatas = chartRightangleSeries.Count > 0 ? chartRightangleSeries : (object)"-";

            var jsondata = new
            {
                title = chartTitle,
                tooltip = chartTooltip,
                calculable = isCalculable,
                legend = chartLegend,
                grid = chartGrid,
                xAxis = chartXAxis,
                yAxis = chartYAxis,
                series = seriesDatas
            };
            return jsondata.ToJson();
        }

        /// <summary>
        /// 多维条形图数据处理
        /// </summary>
        /// <param name="charttitle">标题</param>
        /// <param name="chartAxisData">坐标轴数据</param>
        /// <param name="seriesData">图表数据</param>
        /// <param name="chartLegend">图例</param>
        /// <param name="chartGrid">直角坐标系内绘图网格</param>
        /// <param name="chatsubtitle">副标题文本，默认值：''，'\n'指定换行</param>
        /// <param name="isCalculable">是否启用拖拽重计算特性，默认关闭</param>
        /// <returns>图表所有数据</returns>
        public static string ChartDuoWeiTiaoBarDataProcess(string charttitle, List<object> chartAxisData, IEnumerable<ChartRightangleSeries> seriesData, ChartLegend chartLegend, ChartGrid chartGrid, string chatsubtitle = null, bool isCalculable = false)
        {
            //标题
            var chartTitle = new ChartTitle()
            {
                text = charttitle,
                subtext = chatsubtitle
            };
            //提示框
            var chartTooltip = new ChartTooltip()
            {
                trigger = "axis",
                axisPointer = new AxisPointer()// 坐标轴指示器，坐标轴触发有效
                {
                    type = "shadow"
                },
                formatter = "{b}<br/>{a0}:{c0}<br/>{a2}:{c2}<br/>{a4}:{c4}"
            };

            //X坐标轴
            var chartXAxis = new List<ChartAxis>()
            {
               new ChartAxis
               {
                   type = "value",
                   position = "top",
                   splitLine=new SplitLine()
                   {
                       show = false
                   },
                   axisLabel=new AxisLabel()
                   {
                       show = false
                   }
               }
            };

            //Y坐标轴
            var chartYAxis = new List<ChartAxis>()
            {
                    new ChartAxis()
                    {
                        type = "category", 
                        splitLine=new SplitLine()
                        {
                            show = false
                        },
                        data = chartAxisData
                    }
            };



            //数据
            var chartRightangleSeries = new List<ChartRightangleSeries>();
            chartRightangleSeries.AddRange(seriesData);
            var seriesDatas = chartRightangleSeries.Count > 0 ? chartRightangleSeries : (object)"-";

            var jsondata = new
            {
                title = chartTitle,
                tooltip = chartTooltip,
                legend = chartLegend,
                calculable = isCalculable,
                grid = chartGrid,
                xAxis = chartXAxis,
                yAxis = chartYAxis,
                series = seriesDatas
            };
            return jsondata.ToJson();
        }
    }
}