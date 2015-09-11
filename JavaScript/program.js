var result = new Array();
for (var i = 0; i < 10; i++)
{
    result[i] = function(){
	return i;
    };
}
for (var j = 0;j<10;j++){
    document.writeln(result[j]);
}