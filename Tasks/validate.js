// Validate person name

const isValidate = (personName) => {
if (!personName) return false;
if (personName === '') return false;
if (typeof personName !== 'string') return false;
if (personName.length === 0) return false;
if (!personName.includes(' ')) return false; {
  for (C of personName) {
    if (C === ' ') continue;
    if (C.toLowerCase().charCodeAt(0) >= 97 && C.toLowerCase().charCodeAt(0) <= 122) { } else { return false; }
  };
  return true;
};
};

const result = isValidate('Marcus Aurelius');
console.log(result);
