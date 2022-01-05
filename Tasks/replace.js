// Replace substring with newstr
'use strict';


const replace = (str, subStr, newStr) => {
  if (subStr === '') {
    return str;
  }
  let res = str.split(subStr);
  return res.join(newStr);
}

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
