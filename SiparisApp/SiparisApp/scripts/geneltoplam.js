function Carpma() {
	var s1 = Number(document.getElementById("sayi1").value);
	var s2 = Number(document.getElementById("sayi2").value);
	var sonuc = s1 * s2;
	document.getElementById("kutuSonuc").innerHTML = "Genel Toplam : " + sonuc;
}