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