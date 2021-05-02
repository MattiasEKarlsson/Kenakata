function initialize() {
    var latlng = new google.maps.LatLng(59.246560532169966, 18.061504956334943);
    var options = {
        zoom: 14, center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);
}

function wishlistheart() {

    console.log("hejsan");


}
function increaseValue(id) {
    //var strings = document.getElementById('product-quantity').value;
    var newid = "product-quantity" + id;
    console.log(newid)
    var strings = document.getElementById(newid).value;
    console.log(strings)
    //var now = document.getElementsByTagName("input")[idcorrect].id;
    //console.log(now)
    //var strings = document.getElementById(now).value;
    var value = parseInt(strings);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById(newid).value = value;
    return value;
    //document.getElementById(now).value = value;
}


function decreaseValue(id) {
    var idcorrect = id - 1;
    console.log(idcorrect)


    var newid = "product-quantity" + id;
    console.log(newid)
    var strings = document.getElementById(newid).value;
    console.log(strings)
    var value = parseInt(strings);
    value = isNaN(value) ? 0 : value;
    if (value != 0) {
        value--;
    }
    document.getElementById(newid).value = value;
    return value;

}

