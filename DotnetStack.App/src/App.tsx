import React, { useState } from "react";
import "./App.css";
import { get } from "./utilities/apiHandler";
import moment from "moment";

interface IForecast {
  date: string;
  summary: string;
  temperatureC: number;
  temperatureF: number;
}

function App() {
  const [weather, setWeather] = useState<IForecast[] | null>();
  const handleWeatherClick = async () => {
    const result = await get<IForecast[]>("/api/weatherforecast");
    setWeather(result.data);
  };

  return (
    <div className="App">
      <header className="App-header">
        <button onClick={handleWeatherClick}>Get Weather</button>

        {weather &&
          weather.map((f) => (
            <div key={f.date}>
              <div>
                {moment(f.date).format("LL")} - {f.summary}
              </div>
              <div>{f.temperatureF}&deg;</div>
            </div>
          ))}
      </header>
    </div>
  );
}

export default App;
