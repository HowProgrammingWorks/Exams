// Validate person name
'use strict'

const isValid = (T) => {
if (!T) return false;
if (T === '') return false;
if (typeof T !== 'string') return false;
if (T.length === 0) return false;
if (!T.includes(' ')) return false; {
  for (C of T) {
    if (C === ' ') continue;
    if (C.toLowerCase().charCodeAt(0) >= 97 && C.toLowerCase().charCodeAt(0) <= 122) { } else { return false; }
  };
  return true;
};
};

const result = isValid('Marcus Aurelius');
console.log(result);
