// Replace substring with newstr
'use strict';

const Replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  } else {
    let res = '';
    while (true) {
      const index = str.indexOf(substr);
      if (index !== -1) {
        const start = str.substring(0, index);
        str = str.substring(index + substr.length, str.length);
        res += start + newstr;
      } else {
        return res + str;
      }
    }
  }
};
const result = Replace('Hello <username> and bye!', '<username>', 'Marcus');
const result2 = Replace('AVE <user>, <user>, <user> !!',  '<user>',  'Marcus');
console.log(result, result2);
