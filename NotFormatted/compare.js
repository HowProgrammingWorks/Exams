// Compare two dictionaries

let compare=(
  (first_values,...parameters_LIST) => {
   const second_values = parameters_LIST[0]
   let a = Object.keys(first_values)
   let b = Object.keys(second_values)
   if (a.join('-') !== b.join('-')) return false;
   let e = true;
   for (c of a) {
    if (first_values[c] === second_values[c]) e = e && true
   else { e = e && false }
   }
  return e;
  }
)

require('../Tests/compare.js')(compare);
