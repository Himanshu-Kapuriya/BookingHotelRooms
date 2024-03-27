const landing_accordion = document.getElementsByClassName("landing_covidInfo_accordion");

for (let i = 0; i < landing_accordion.length; i++) {
    landing_accordion[i].addEventListener("click", function() {
        this.classList.toggle("landing_covidInfo_list_active");
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
        panel.style.display = "none";
        } 
        else {
        panel.style.display = "block";
        }
    });
}

function search() {
    var data=document.querySelector("#t_goa55").value
    var data= data.toLowerCase()
    window.location.href=`${data}.html`
}

//  <div id="t_goa_itc">
//      <img id="t_goa_itc_img" src="https://t-cf.bstatic.com/xdata/images/hotel/square200/163940147.webp?k=a645641232f44cefc2265b0f65215a4ed4a73aafb3e860fac39b54f6a17a8369&o="/>
//     <div id="t_goa_itc1">
//         <h2>ITC Grand Goa, a Luxury Collection Resort & <br> Spa <i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-star"></i><i class="fa fa-thumbs-up"></i></h2>
//     <p>ITC Grand Goa Resort & Spa is set within 45 acres of landscaped gardens with <br> glimmering waterways and lagoons along the pristine Arossim Beach.</p>
//     <p id="t_goa_book">Book 6 times in last 6 hours</p>
//     </div>
//     <div id="t_goa_good">
//         <button>8.4</button><h3 >Very good</h3>
//        <p style="margin-top: -10px;"> 486 reviews</p>
//        <button id="t_goa_good1"> Show prices</button>
//     </div>
// </div>
//  var aaa=document.querySelector('#t_goa_itc')
var a=document.querySelector('.t_dom1')
var b=document.querySelector('.t_dom2')
var c=document.querySelector('.t_dom3')
var d=document.querySelector('.t_dom4')
var e=document.querySelector('.t_dom5')
var f=document.querySelector('.t_dom6')
var g=document.querySelector('.t_dom7')
var h=document.querySelector('.t_dom8')
var i=document.querySelector('.t_dom9')
var j=document.querySelector('.t_dom10')
// console.log(a)
function highest(){
var a=document.querySelector('.t_dom1')
var b=document.querySelector('.t_dom2')
var c=document.querySelector('.t_dom3')
var d=document.querySelector('.t_dom4')
var e=document.querySelector('.t_dom5')
var f=document.querySelector('.t_dom6')
var g=document.querySelector('.t_dom7')
var h=document.querySelector('.t_dom8')
var i=document.querySelector('.t_dom9')
var j=document.querySelector('.t_dom10')
  console.log(a,b)
  var p=a.innerHTML 
  var q=e.innerHTML 
  a.innerHTML=j.innerHTML
  j.innerHTML=i.innerHTML
  i.innerHTML=c.innerHTML
  c.innerHTML=b.innerHTML
  b.innerHTML=d.innerHTML         
  d.innerHTML=g.innerHTML
  g.innerHTML=p
  e.innerHTML=h.innerHTML
  f.innerHTML=f.innerHTML          
  h.innerHTML=q   
 
}
function lowest(){
var a=document.querySelector('.t_dom1')
var b=document.querySelector('.t_dom2')
var c=document.querySelector('.t_dom3')
var d=document.querySelector('.t_dom4')
var e=document.querySelector('.t_dom5')
var f=document.querySelector('.t_dom6')
var g=document.querySelector('.t_dom7')
var h=document.querySelector('.t_dom8')
var i=document.querySelector('.t_dom9')
var j=document.querySelector('.t_dom10')
  var p=a.innerHTML
  var q=b.innerHTML
  var r=d
  a.innerHTML=i.innerHTML
  i.innerHTML=d.innerHTML  
  d.innerHTML=p

  b.innerHTML=c.innerHTML
  c.innerHTML=e.innerHTML         
  e.innerHTML=f.innerHTML         
  f.innerHTML=h.innerHTML
  g.innerHTML=g.innerHTML
  h.innerHTML=q                 
  j.innerHTML=j.innerHTML
}
function reviews(){
var a=document.querySelector('.t_dom1')
var b=document.querySelector('.t_dom2')
var c=document.querySelector('.t_dom3')
var d=document.querySelector('.t_dom4')
var e=document.querySelector('.t_dom5')
var f=document.querySelector('.t_dom6')
var g=document.querySelector('.t_dom7')
var h=document.querySelector('.t_dom8')
var i=document.querySelector('.t_dom9')
var j=document.querySelector('.t_dom10')
  var p=a.innerHTML
  var q=c.innerHTML
  var r=f.innerHTML
  a.innerHTML=d.innerHTML
  d.innerHTML=j.innerHTML
  j.innerHTML=i.innerHTML
  i.innerHTML=e.innerHTML
  e.innerHTML=p  
  
  b.innerHTML=b.innerHTML
  c.innerHTML=g.innerHTML 
  g.innerHTML=q        
         
  f.innerHTML=h.innerHTML
  
  h.innerHTML=r                 
 
}
