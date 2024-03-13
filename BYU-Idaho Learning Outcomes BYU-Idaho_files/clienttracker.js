/*! For license information please see clienttracker.js.LICENSE.txt */
(()=>{var t={7061:(t,e,n)=>{var r=n(8698).default;function o(){"use strict";t.exports=o=function(){return e},t.exports.__esModule=!0,t.exports.default=t.exports;var e={},n=Object.prototype,a=n.hasOwnProperty,i=Object.defineProperty||function(t,e,n){t[e]=n.value},c="function"==typeof Symbol?Symbol:{},u=c.iterator||"@@iterator",s=c.asyncIterator||"@@asyncIterator",l=c.toStringTag||"@@toStringTag";function f(t,e,n){return Object.defineProperty(t,e,{value:n,enumerable:!0,configurable:!0,writable:!0}),t[e]}try{f({},"")}catch(t){f=function(t,e,n){return t[e]=n}}function h(t,e,n,r){var o=e&&e.prototype instanceof p?e:p,a=Object.create(o.prototype),c=new _(r||[]);return i(a,"_invoke",{value:D(t,n,c)}),a}function d(t,e,n){try{return{type:"normal",arg:t.call(e,n)}}catch(t){return{type:"throw",arg:t}}}e.wrap=h;var y={};function p(){}function v(){}function g(){}var b={};f(b,u,(function(){return this}));var m=Object.getPrototypeOf,w=m&&m(m(O([])));w&&w!==n&&a.call(w,u)&&(b=w);var x=g.prototype=p.prototype=Object.create(b);function k(t){["next","throw","return"].forEach((function(e){f(t,e,(function(t){return this._invoke(e,t)}))}))}function L(t,e){function n(o,i,c,u){var s=d(t[o],t,i);if("throw"!==s.type){var l=s.arg,f=l.value;return f&&"object"==r(f)&&a.call(f,"__await")?e.resolve(f.__await).then((function(t){n("next",t,c,u)}),(function(t){n("throw",t,c,u)})):e.resolve(f).then((function(t){l.value=t,c(l)}),(function(t){return n("throw",t,c,u)}))}u(s.arg)}var o;i(this,"_invoke",{value:function(t,r){function a(){return new e((function(e,o){n(t,r,e,o)}))}return o=o?o.then(a,a):a()}})}function D(t,e,n){var r="suspendedStart";return function(o,a){if("executing"===r)throw new Error("Generator is already running");if("completed"===r){if("throw"===o)throw a;return{value:void 0,done:!0}}for(n.method=o,n.arg=a;;){var i=n.delegate;if(i){var c=S(i,n);if(c){if(c===y)continue;return c}}if("next"===n.method)n.sent=n._sent=n.arg;else if("throw"===n.method){if("suspendedStart"===r)throw r="completed",n.arg;n.dispatchException(n.arg)}else"return"===n.method&&n.abrupt("return",n.arg);r="executing";var u=d(t,e,n);if("normal"===u.type){if(r=n.done?"completed":"suspendedYield",u.arg===y)continue;return{value:u.arg,done:n.done}}"throw"===u.type&&(r="completed",n.method="throw",n.arg=u.arg)}}}function S(t,e){var n=e.method,r=t.iterator[n];if(void 0===r)return e.delegate=null,"throw"===n&&t.iterator.return&&(e.method="return",e.arg=void 0,S(t,e),"throw"===e.method)||"return"!==n&&(e.method="throw",e.arg=new TypeError("The iterator does not provide a '"+n+"' method")),y;var o=d(r,t.iterator,e.arg);if("throw"===o.type)return e.method="throw",e.arg=o.arg,e.delegate=null,y;var a=o.arg;return a?a.done?(e[t.resultName]=a.value,e.next=t.nextLoc,"return"!==e.method&&(e.method="next",e.arg=void 0),e.delegate=null,y):a:(e.method="throw",e.arg=new TypeError("iterator result is not an object"),e.delegate=null,y)}function j(t){var e={tryLoc:t[0]};1 in t&&(e.catchLoc=t[1]),2 in t&&(e.finallyLoc=t[2],e.afterLoc=t[3]),this.tryEntries.push(e)}function E(t){var e=t.completion||{};e.type="normal",delete e.arg,t.completion=e}function _(t){this.tryEntries=[{tryLoc:"root"}],t.forEach(j,this),this.reset(!0)}function O(t){if(t){var e=t[u];if(e)return e.call(t);if("function"==typeof t.next)return t;if(!isNaN(t.length)){var n=-1,r=function e(){for(;++n<t.length;)if(a.call(t,n))return e.value=t[n],e.done=!1,e;return e.value=void 0,e.done=!0,e};return r.next=r}}return{next:T}}function T(){return{value:void 0,done:!0}}return v.prototype=g,i(x,"constructor",{value:g,configurable:!0}),i(g,"constructor",{value:v,configurable:!0}),v.displayName=f(g,l,"GeneratorFunction"),e.isGeneratorFunction=function(t){var e="function"==typeof t&&t.constructor;return!!e&&(e===v||"GeneratorFunction"===(e.displayName||e.name))},e.mark=function(t){return Object.setPrototypeOf?Object.setPrototypeOf(t,g):(t.__proto__=g,f(t,l,"GeneratorFunction")),t.prototype=Object.create(x),t},e.awrap=function(t){return{__await:t}},k(L.prototype),f(L.prototype,s,(function(){return this})),e.AsyncIterator=L,e.async=function(t,n,r,o,a){void 0===a&&(a=Promise);var i=new L(h(t,n,r,o),a);return e.isGeneratorFunction(n)?i:i.next().then((function(t){return t.done?t.value:i.next()}))},k(x),f(x,l,"Generator"),f(x,u,(function(){return this})),f(x,"toString",(function(){return"[object Generator]"})),e.keys=function(t){var e=Object(t),n=[];for(var r in e)n.push(r);return n.reverse(),function t(){for(;n.length;){var r=n.pop();if(r in e)return t.value=r,t.done=!1,t}return t.done=!0,t}},e.values=O,_.prototype={constructor:_,reset:function(t){if(this.prev=0,this.next=0,this.sent=this._sent=void 0,this.done=!1,this.delegate=null,this.method="next",this.arg=void 0,this.tryEntries.forEach(E),!t)for(var e in this)"t"===e.charAt(0)&&a.call(this,e)&&!isNaN(+e.slice(1))&&(this[e]=void 0)},stop:function(){this.done=!0;var t=this.tryEntries[0].completion;if("throw"===t.type)throw t.arg;return this.rval},dispatchException:function(t){if(this.done)throw t;var e=this;function n(n,r){return i.type="throw",i.arg=t,e.next=n,r&&(e.method="next",e.arg=void 0),!!r}for(var r=this.tryEntries.length-1;r>=0;--r){var o=this.tryEntries[r],i=o.completion;if("root"===o.tryLoc)return n("end");if(o.tryLoc<=this.prev){var c=a.call(o,"catchLoc"),u=a.call(o,"finallyLoc");if(c&&u){if(this.prev<o.catchLoc)return n(o.catchLoc,!0);if(this.prev<o.finallyLoc)return n(o.finallyLoc)}else if(c){if(this.prev<o.catchLoc)return n(o.catchLoc,!0)}else{if(!u)throw new Error("try statement without catch or finally");if(this.prev<o.finallyLoc)return n(o.finallyLoc)}}}},abrupt:function(t,e){for(var n=this.tryEntries.length-1;n>=0;--n){var r=this.tryEntries[n];if(r.tryLoc<=this.prev&&a.call(r,"finallyLoc")&&this.prev<r.finallyLoc){var o=r;break}}o&&("break"===t||"continue"===t)&&o.tryLoc<=e&&e<=o.finallyLoc&&(o=null);var i=o?o.completion:{};return i.type=t,i.arg=e,o?(this.method="next",this.next=o.finallyLoc,y):this.complete(i)},complete:function(t,e){if("throw"===t.type)throw t.arg;return"break"===t.type||"continue"===t.type?this.next=t.arg:"return"===t.type?(this.rval=this.arg=t.arg,this.method="return",this.next="end"):"normal"===t.type&&e&&(this.next=e),y},finish:function(t){for(var e=this.tryEntries.length-1;e>=0;--e){var n=this.tryEntries[e];if(n.finallyLoc===t)return this.complete(n.completion,n.afterLoc),E(n),y}},catch:function(t){for(var e=this.tryEntries.length-1;e>=0;--e){var n=this.tryEntries[e];if(n.tryLoc===t){var r=n.completion;if("throw"===r.type){var o=r.arg;E(n)}return o}}throw new Error("illegal catch attempt")},delegateYield:function(t,e,n){return this.delegate={iterator:O(t),resultName:e,nextLoc:n},"next"===this.method&&(this.arg=void 0),y}},e}t.exports=o,t.exports.__esModule=!0,t.exports.default=t.exports},8698:t=>{function e(n){return t.exports=e="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},t.exports.__esModule=!0,t.exports.default=t.exports,e(n)}t.exports=e,t.exports.__esModule=!0,t.exports.default=t.exports},4687:(t,e,n)=>{var r=n(7061)();t.exports=r;try{regeneratorRuntime=r}catch(t){"object"==typeof globalThis?globalThis.regeneratorRuntime=r:Function("r","regeneratorRuntime = r")(r)}}},e={};function n(r){var o=e[r];if(void 0!==o)return o.exports;var a=e[r]={exports:{}};return t[r](a,a.exports,n),a.exports}n.n=t=>{var e=t&&t.__esModule?()=>t.default:()=>t;return n.d(e,{a:e}),e},n.d=(t,e)=>{for(var r in e)n.o(e,r)&&!n.o(t,r)&&Object.defineProperty(t,r,{enumerable:!0,get:e[r]})},n.o=(t,e)=>Object.prototype.hasOwnProperty.call(t,e),(()=>{"use strict";var t=n(4687),e=n.n(t);const r={set:function(t,e,n,r){var o=4<arguments.length&&void 0!==arguments[4]?arguments[4]:null,a=encodeURI(t),i=encodeURI(e),c=o?o.toUTCString():"";document.cookie="".concat(a,"=").concat(i,";expires=").concat(c,";domain=.").concat(n,";path=").concat(r)},get:function(t){var e=document.cookie.match(new RegExp("(^| )".concat(t,"=([^;]+)")));return e?e[2]:null}},o=function(){var t="bluCookieSynced",e="",n="",o=function(){var n=new Date,o=new Date(n.getFullYear()+2,n.getMonth(),n.getDate()),a=n.getTime();r.set(t,a,e,"/",o)},a=function(){var e=parseInt(r.get(t),10)||null;return!!e&&e+2592e6>(new Date).getTime()},i=function(t){var e="https://match.prod.bidr.io/cookie-sync/deseret"+n;(!1===a()||t)&&function(t,e){var n=new Image;n.onload=e,n.src=t}(e,o)};return function(){var t=0<arguments.length&&void 0!==arguments[0]?arguments[0]:{};t.domain&&function(t){e=t}(t.domain),t.syncQueryString&&function(){var t=0<arguments.length&&void 0!==arguments[0]?arguments[0]:{},e="",r=Object.keys(t),o="?";r.forEach((function(n){e="".concat(e).concat(o).concat(n,"=").concat(t[n]),o="&"})),n=e}(t.syncQueryString),(!1===a()||t.forceResync)&&i(t.forceResync)}(0<arguments.length&&void 0!==arguments[0]?arguments[0]:{}),{cookieSync:i,isSynced:a}};function a(t){return a="function"==typeof Symbol&&"symbol"==typeof Symbol.iterator?function(t){return typeof t}:function(t){return t&&"function"==typeof Symbol&&t.constructor===Symbol&&t!==Symbol.prototype?"symbol":typeof t},a(t)}function i(t,e){if(!(t instanceof e))throw new TypeError("Cannot call a class as a function")}function c(t){var e=function(t,e){if("object"!==a(t)||null===t)return t;var n=t[Symbol.toPrimitive];if(void 0!==n){var r=n.call(t,"string");if("object"!==a(r))return r;throw new TypeError("@@toPrimitive must return a primitive value.")}return String(t)}(t);return"symbol"===a(e)?e:String(e)}function u(t,e){for(var n=0;n<e.length;n++){var r=e[n];r.enumerable=r.enumerable||!1,r.configurable=!0,"value"in r&&(r.writable=!0),Object.defineProperty(t,c(r.key),r)}}function s(t,e,n){return e&&u(t.prototype,e),n&&u(t,n),Object.defineProperty(t,"prototype",{writable:!1}),t}function l(t,e,n){return(e=c(e))in t?Object.defineProperty(t,e,{value:n,enumerable:!0,configurable:!0,writable:!0}):t[e]=n,t}window.console||(window.console={});var f=function(){function t(){i(this,t)}return s(t,null,[{key:"isRubyBluDebug",value:function(){var t=window.location.href;return/debug_rubyblu_tracker=1/.test(t)}},{key:"canLog",value:function(){var t=0<arguments.length&&void 0!==arguments[0]?arguments[0]:"log";return this.isRubyBluDebug()&&console[t]}},{key:"Error",value:function(){var t;this.canLog("error")&&(t=console).error.apply(t,arguments)}},{key:"Info",value:function(){var t;this.canLog("log")&&(t=console).log.apply(t,arguments)}}]),t}(),h=function(){function t(e,n){i(this,t),l(this,"log",null),l(this,"cookie",null),this.log=e,this.cookie=n}return s(t,[{key:"Get",value:function(){return{SiteUserID:this.cookie.get("bluSiteUserID")||"",UserAgent:navigator.userAgent,USPrivacy:this.cookie.get("usprivacy")||""}}}]),t}(),d=function(){function t(e,n){i(this,t),l(this,"log",null),l(this,"cookie",null),l(this,"shouldLoadData",!0),l(this,"user",{}),l(this,"dataLayer",null),l(this,"googleAdManager",null),this.log=e,this.cookie=n,this.user=new h(e,n)}return s(t,[{key:"Done",value:function(){this.shouldLoadData=!1}},{key:"User",value:function(){return this.user.Get()}},{key:"DataLayer",value:function(){return this.dataLayer||{}}},{key:"setDataLayer",value:function(t,e){null===this.dataLayer&&(this.dataLayer={}),this.dataLayer[t]=e}},{key:"LoadDataLayer",value:function(){var t=this,e=0<arguments.length&&void 0!==arguments[0]?arguments[0]:null;if(!1!==this.shouldLoadData&&e&&this.retryData(e,"push",(function(){t.LoadDataLayer(e)}))){var n=[],r={};try{for(var o=function(o){var i=function(t){var e={},n=function(t,r){var o=2<arguments.length&&void 0!==arguments[2]?arguments[2]:1;Object.keys(t).forEach((function(a){var i=t[a],c=Array.isArray(i),u=Object.prototype.toString.call(i),s=r?r+"."+a:a;return c||"[object Object]"!==u&&"[object Array]"!==u||!Object.keys(i).length?void(e[s]=c?i.join(","):i):n(i,s,o+1)}))};return n(t),e}(e[o]);Object.keys(i).forEach((function(e){var o=i[e];i[e]=o+"","object"===a(o)&&(Array.isArray(o)&&0<o.length&&"object"!==a(o[0])?(o=o.join(","),t.log.Info("assumed type off of first element")):(o=JSON.stringify(o),t.log.Info("encountered an object that needs further parsing"))),"event"===e?n.push(o):r[e]=(o+"").substr(0,450)}))},i=0;i<e.length;i+=1)o(i)}catch(t){this.setDataLayer("error",!0),this.setDataLayer("errorMsg",t.toString()),this.log.Error(t)}this.setDataLayer("Events",n),this.setDataLayer("Attributes",r)}}},{key:"retryFunction",value:function(){var t=0<arguments.length&&void 0!==arguments[0]?arguments[0]:function(){},e=1<arguments.length&&void 0!==arguments[1]?arguments[1]:500;!1===this.shouldLoadData||setTimeout((function(){return t()}),e)}},{key:"retryData",value:function(){var t=0<arguments.length&&void 0!==arguments[0]?arguments[0]:{},e=1<arguments.length&&void 0!==arguments[1]?arguments[1]:"",n=2<arguments.length&&void 0!==arguments[2]?arguments[2]:function(){};return!(!1===this.shouldLoadData||!Object.prototype.hasOwnProperty.call(t,e)&&(setTimeout((function(){return n()}),500),1))}},{key:"Loaded",value:function(){return!1===this.shouldLoadData||null!==this.dataLayer&&null!==this.googleAdManager&&!1!==this.user.cohort}}]),t}();l(d,"loaded",!1),window.rubyBluClientPageData||(window.rubyBluClientPageData=new d(f,r));const y=window.rubyBluClientPageData,p=function(){var t;return e().async((function(n){for(;;)switch(n.prev=n.next){case 0:return n.prev=0,n.next=3,e().awrap(fetch("https://region-filter.rubyblu.com/check",{method:"GET"}).then((function(t){return t.text()})));case 3:return t=n.sent,n.abrupt("return","denied"!==t);case 7:return n.prev=7,n.t0=n.catch(0),n.abrupt("return",!0);case 10:case"end":return n.stop()}}),null,null,[[0,7]])};function v(t,n){function a(t){window.isRubyBluDebug()&&console&&console.log(t)}function i(){return l(2147483648*Math.random()).toString(36)+Math.abs(l(2147483648*Math.random())^Date.now()).toString(36)}function c(t){var e=t.eventTagID,n=t.accountID,r=void 0===n?2:n,o=t.segmentKey,a=void 0===o?"":o,i=t.value,c=void 0===i?"":i,u=new Image;u.width=0,u.height=0;var s=l(1e10*Math.random());u.src="https://cnv.event.prod.bidr.io/log/cnv?tag_id=".concat(e,"&buzz_key=deseret&value=").concat(c,"&segment_key=").concat(a,"&account_id=").concat(r,"&order=[ORDER]&ord=").concat(s),document.body.appendChild(u)}function u(t,e){var n=JSON.stringify(e);if(navigator.sendBeacon)a("Attempting send via sendBeacon"),navigator.sendBeacon(t,n)&&a("Data Sent: ".concat(n));else{a("Attempting send via xhr");var r=new XMLHttpRequest;r.open("POST",t,!0),r.setRequestHeader("Content-Type","application/json; charset=UTF-8"),r.send(n),r.onloadend=function(){a("Data Sent: ".concat(n))}}}function s(t,e,r){a("sending pixel-beacon"),a("Attempt #".concat(r+1));var o=window.location.pathname+window.location.search,c="".concat(window.location.protocol,"//").concat(window.location.host).concat(o),l=window.location.protocol;-1<l.indexOf(":")&&(l=l.replace(":",""));var f=!1;if(w&&(f=w.isSynced()&&d),!f&&m&&6>r)return a("Incomplete Data. Waiting..."),a(w?"rubybluCookieSyncFunctions.isSynced(): ".concat(w.isSynced()):"rubybluCookieSyncFunctions ".concat(w)),a("CookiesSet both (rubyblu and site): ".concat(f," only the site cookie: ").concat(d)),a("cookiesAccepted ".concat(m)),void setTimeout((function(){return s(t,e,r+1)}),1e3);u("https://client-pixel.rubyblu.com/publishClientBeacon",{HitVersion:1,BeaconId:i(),Client:t,AudienceSegmentID:e,TimestampNanoseconds:1e6*(new Date).getTime(),User:n.User(),Page:{URL:c,Title:document.title,Protocol:l,Domain:window.location.host,Uri:o},DataLayer:n.DataLayer(),CookiesAccepted:m,CookiesSet:f,NumRetries:r})}var l=Math.floor;a("rubyblu client constructor");var f="",h=!1,d=!1,y=!1,v=function(){a(window.location.hostname);var t=(window.location.hostname||"").match(/[^\.]*\.[^.]*$/);return t&&t[0]}(),g="wait",b=[],m=!(window.doNotTrack||navigator.doNotTrack||navigator.msDoNotTrack)||"1"!==window.doNotTrack&&"yes"!==navigator.doNotTrack&&"1"!==navigator.doNotTrack&&"1"!==navigator.msDoNotTrack,w=null;return t&&t.cmd&&0<t.cmd.length&&(b=t.cmd),{cmd:{push:function(t){"wait"===g?b.push(t):t()}},run:function(){return e().async((function(t){for(;;)switch(t.prev=t.next){case 0:return a("rubyblu client script start"),t.next=3,e().awrap(p());case 3:if(t.sent){t.next=7;break}return b=[],a("exiting rubyblu client script"),t.abrupt("return");case 7:for(;0<b.length;)b.shift()();g="run";case 9:case"end":return t.stop()}}))},send:s,sendBeacon:u,sendEvent:c,handleData:function(t,n){return function(){var t,n,r,o,i,u=arguments;e().async((function(s){for(;;)switch(s.prev=s.next){case 0:return t=0<u.length&&void 0!==u[0]?u[0]:"",s.prev=1,s.next=4,e().awrap(fetch("https://api.rubyblu.com/event-tags?audience-segment=".concat(t,"&page-url=").concat(window.location.href),{method:"GET"}));case 4:return n=s.sent,s.next=7,e().awrap(n.json());case 7:r=s.sent,o=r.TagID,i=r.AccountID,c({eventTagID:o,accountID:void 0===i?2:i}),s.next=17;break;case 14:s.prev=14,s.t0=s.catch(1),a("Failed to set event tag ".concat(s.t0));case 17:case"end":return s.stop()}}),null,null,[[1,14]])}(n),h||(h=!0,function(t){if(f=r.get("bluSiteUserID"),m)if(f&&function(t){return!!(7<=t.length)&&"client."===t.substr(0,7)}(f))d=!0;else{f="".concat("client.").concat(i()),a("setting ".concat("bluSiteUserID"," cookie"));var e=new Date,n=new Date(e.getFullYear()+2,e.getMonth(),e.getDate());r.set("bluSiteUserID",f,t,"/",n),d=!0,y=!0}else d=!0}(v),a("attempting to forward cookie sync"),m?w=o({syncQueryString:{buyer_user_id:f},domain:v,forceResync:y}):a("customer requested we don't cookie sync with them or the feature is not supported")),void s(t,n,0)},setDomain:function(t){v=t},parseGtmDataLayer:function(t){n.LoadDataLayer(t)}}}window.isRubyBluDebug=function(){var t=window.location.href;return/debug_rubyblu_tracker=1/.test(t)},window.setupRubyBlu||(window.setupRubyBlu=v),window.rubyblu=v(window.rubyblu,y),window.rubyblu.run()})()})();