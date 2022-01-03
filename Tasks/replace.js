// Replace substring with newstr
'use strict';

const Replace = (str, substr, newstr) => {
  if (substr === '') {
    return str;
  } else {
    let res = '';
    while (true) {
      const index = str.indexOf(substr);
      if (index === -1) {
        return res + str;
      } else {
        const start = str.substring(0, index);
        str = str.substring(index + substr.length, str.length);
        res += start + newstr;
      }
    }
  }
};
const result = Replace('Hello <username> and bye!', '<username>', 'Marcus');
const result2 = Replace('Hi <username>, How are you? Great job <username>!',  '<username>',  'Marcus');
console.log(result, result2);
