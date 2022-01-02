// Change douple quotation to open or close quotation

function quotes(string) {
 res = [];
 open = false;
 for (character of string) {
   if (character === '"') {
       if (!open) {
           res.push('«');
           open = true;
       } else {
           res.push('»');
           open = false;
       }
   } else {
       res.push(character);
   }
 }
 return res.join('');
}

console.log(quotes('Hello "Marcus"! Ave "Marcus"!'))