
var req;

function loadXMLDoc(id) {
if (window.XMLHttpRequest) { 
req = new XMLHttpRequest(); 
}
else if (window.ActiveXObject) { 
req = new ActiveXObject("Microsoft.XMLHTTP"); 
}
if (req) { 
req.onreadystatechange = work;
req.open("GET", "detalji.php?id="+id, true); 
req.send(null);
} 
}


function work() {
if(req.readyState!=4){
document.getElementById("info").innerHTML="<img src = 'loading.gif'>";


}
if (req.readyState == 4) { 
if (req.status == 200) { 
document.getElementById("info").innerHTML=req.responseText;
} 
else { 
alert("Nije primljen 200 OK, nego:\n" + req.statusText);
}
}
}