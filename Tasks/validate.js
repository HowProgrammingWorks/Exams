// Validate person name
'use strict';

const validName = (name) => {
  if (typeof name === 'string') {
    const regEx = /[A-Z]/;
    const words = name.split(' ');
    for (let word of words) {
      if (!regEx.test(word)) return false;
    }
    return true;
  }
  else return false;
}

const result = validName('Marcus Aurelius');
console.log(result);
