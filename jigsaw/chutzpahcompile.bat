call npm install 
call .\node_modules\.bin\babel.cmd --presets react,env js/*.jsx --out-file wwwroot/js/chutzpah.js
call .\node_modules\.bin\babel.cmd --presets react,env jsx/testjsx/chutzpah.test.jsx --out-file jsx/testjs/chutzpah.test.js