$(function(){$(".tips-closed").click(function(){$("#mqtips").hide()})});function batchsubmit2(){var arr=window.getSelect();var infoids=[];if(!arr.length){alert("请先选择职位！");return}for(var i=0,len=arr.length;i<len;i++){infoids.push($(arr[i]).attr("infoid"))}var cid="";if(____json4fe.catentry.length>=2){cid="&c="+____json4fe.catentry[1].dispid}if(____json4fe.catentry.length>=3){cid=cid+"&d="+____json4fe.catentry[2].dispid}var url="http://jianli.58.com/resumedelivery/?infoid="+infoids.join(",")+"&fromType=2&itype=1"+cid;setbg("批量投递简历",600,345,url,true);_gaq.push(["pageTracker._trackEvent","list","click","/zhaopin/deliver/click_list/"])}$(function(){$(".selWel i").click(function(){var $this=$(this);var $next=$this.next();var selected=$this.parent().hasClass("iselect");var url="";if(selected){url=$next.attr("cl")}else{url=$next.attr("clu")}document.location=url});$(".selWel a").click(function(){var $this=$(this);var selected=$this.parent().hasClass("iselect");var url="";if(selected){url=$this.attr("cl")}else{url=$this.attr("clu")}document.location=url;return false});$("#securityCenterTip").click(function(){window.open("http://baozhang.58.com/zhaopin/")})});function intscrbar(maxsize){if($(".resultinfo li").length>maxsize){--maxsize;$("#cateswitch").show();$(".resultinfo li:gt("+maxsize+")").each(function(){$(this).hide()});$("#cateswitch").toggle(function(){$(".resultinfo li:gt("+maxsize+")").each(function(){$(this).show()});$(this).removeClass("hide").text("收起")},function(){$(".resultinfo li:gt("+maxsize+")").each(function(){$(this).hide()});$(this).addClass("hide").text("显示全部")})}else{return false}}intscrbar(5);$(function(){function different_ads(Numads){var timer=null;var _index=0;function switchPicture(){$("#ad_mdmqzp_new .adshow1").removeClass("active");$("#ad_mdmqzp_new .adshow1").eq(_index).addClass("active");$("#ad_mdmqzp_new .adshow1 dl").hide();$("#ad_mdmqzp_new .adshow1 dl").eq(_index).show();_index>Numads-2?_index=0:_index++}timer=setInterval(function(){switchPicture()},6e3);$("#ad_mdmqzp_new .adshow1 dl").mousemove(function(){clearInterval(timer);$(".adshow1").removeClass("active");$(this).parent().addClass("active")});$("#ad_mdmqzp_new .adshow1 h2").mousemove(function(){clearInterval(timer);$(".adshow1").removeClass("active");$(this).parent().addClass("active");$("#ad_mdmqzp_new .adshow1 dl").hide();$(this).siblings("dl").show()});$("#ad_mdmqzp_new .adshow1 dl").mouseout(function(){_index=$(this).parent().index();_index>Numads-2?_index=0:_index++;timer=setInterval(function(){switchPicture()},6e3)});$("#ad_mdmqzp_new .adshow1 h2").mouseout(function(){_index=$(this).parent().index();_index>Numads-2?_index=0:_index++;timer=setInterval(function(){switchPicture()},6e3)})}var numberads=$("#ad_mdmqzp_new .adshow1").length;if(numberads==3||numberads==2){different_ads(numberads)}});