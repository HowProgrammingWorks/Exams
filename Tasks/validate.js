// Validate person name

const isValidate = (T) => {
if (T === '') return false;
if (typeof T !== 'string') return false;
for (C of T) {
    if (C === ' ') continue;
    if (C.toLowerCase().charCodeAt(0) >= 97 && C.toLowerCase().charCodeAt(0) <= 122) { } else { return false; }
  };
  return true;
};

const result = isValidate('Marcus Aurelius');
console.log(result);
