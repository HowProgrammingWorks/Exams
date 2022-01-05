// Replace substring with newstr
'use strict';


const replace = (str, subStr, newStr) => {
  return str.split(subStr).join(newStr);
}

const result = replace('Hello <username> and bye!', '<username>', 'Marcus');
console.log(result);
