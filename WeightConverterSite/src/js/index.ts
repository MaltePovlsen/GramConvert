let gramButton = document.getElementById("ToGramButton");
let ounceButton = document.getElementById("ToOunceButton");

function ConvertToGram(){
    let inputValue: number = Number((<HTMLInputElement>document.getElementById("WeightInputNumber")).value);
    return inputValue * 28.34952;
}

function ConvertToOunces(){
    let inputValue: number = Number((<HTMLInputElement>document.getElementById("WeightInputNumber")).value);
   return inputValue * 0.03527396195;
}

gramButton.onclick = function(){
    let gramResult: number = ConvertToGram();
        document.getElementById("output").innerHTML = gramResult.toString() + " gram";   
}

ounceButton.onclick = function(){
    let ounceResult: number = ConvertToOunces();
    document.getElementById("output").innerHTML = ounceResult.toString() + " ounces";
}

