// Change douple quotation to open or close quotation

const quotes = (string) => {
  let res = [];
  let open = false;
  for (let character of string) {
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

const result = quotes('Hello "Marcus"! Ave "Marcus"!');
console.log(result);