// Validate person name

const Valid = (name) => {
if (name === '') return false;
if (typeof name !== 'string') return false;
for (words of name) {
    if (words === ' ') continue;
    const a = 'a'.charCodeAt(0);
    const z = 'z'.charCodeAt(0);
    if (words.toLowerCase().charCodeAt(0) >= a && words.toLowerCase().charCodeAt(0) <= z) { } else { return false; }
  };
  return true;
};

const result = Valid('Marcus Aurelius');
console.log(result);
