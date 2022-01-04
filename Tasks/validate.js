// Validate person name
'use strict';

const validName = (name) => {
  if (typeof name === 'string') {
    
    const words = name.split(' ');
    for (let word of words) {
      if () return false;
    }
    return true;
  }
  else return false;
}

const result = validName('Marcus Aurelius');
console.log(result);
