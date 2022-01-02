'use strict';
// Validate person name

const isValidate = name => {
  if (!name) return false;
  if (typeof name !== 'string') return false;
  if (!name.includes(' ')) return false;
  const a = 'a'.charCodeAt(0);
  const z = 'z'.charCodeAt(0);
  for (const letter of name) {
    if (letter === ' ') continue;
    const unicode = letter.toLowerCase().charCodeAt(0);
    if (!(unicode >= a && unicode <= z)) { return false; }
  }
  return true;
};

const result = isValidate('Marcus Aurelius');
console.log(result);
