// Replace substring with newStr

replace = (str, substr, newStr) => {
  if (substr === '') {
    return str;
  }
  else {
    src = str;
    res = '';
    do {
      const index = src.indexOf(substr);
      if (index === -1) {
        return res + src;
      } else {
        const start = src.substring(0, index);
        src = src.substring(index + substr.length, src.length);
        res += start + newStr;
      }
    } while (true);
  }
};

require('../Tests/replace.js')(Replace);
