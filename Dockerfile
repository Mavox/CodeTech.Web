FROM node
COPY . /app
WORKDIR /app
RUN npm install
# TODO: angular/cli bör plockas från devdependencies i package.json.
# Detta för att garantera att rätt version används
RUN npm install -g @angular/cli@9.0.2 
ENTRYPOINT ["ng serve", "--host 0.0.0.0"]
CMD ["--port", "80"]