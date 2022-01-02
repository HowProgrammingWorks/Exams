// Change douple quotation to open or close quotation

function quotes(s) {
 res = [];
 open = false;
 for (c of s) {
   if (c === '"') {
       if (!open) {
           res.push('«');
           open = true;
       } else {
           res.push('»');
           open = false;
       }
   } else {
       res.push(c);
   }
 }
 return res.join('');
}

console.log(quotes('Hello "Marcus"! Ave "Marcus"!'))