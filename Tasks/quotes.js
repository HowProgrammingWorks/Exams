// Change douple quotation to open or close quotation

quotes=function(s) {
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

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result)
