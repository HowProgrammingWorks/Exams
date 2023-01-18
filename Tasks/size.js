// Convert number to file size in bytes, kb, mb, and gb

const size = (size) => {
  if (size === 0) return "0 byte";
  const exp = Math.floor(Math.log(size) / Math.log(1000));
  if (exp == 0) return size + " byte";
  if (exp == 1) return Math.round(size / 10e2) + " kb";
  if (exp == 2) return Math.round(size / 10e5) + " mb";
  if (exp == 3) return Math.round(size / 10e8) + " gb";
};

require("../Tests/size.js")(size);
