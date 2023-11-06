import React from "react";
import { IUser } from "../data/User";
import Person from "../media/person.png";

type Props = {
  user: IUser;
};

const Card = (props: Props) => {
  return (
    <div className="card" style={{ width: "12rem" }}>
      <div className="card-body">
        <h5
          className="card-title"
          style={{
            fontWeight: "bold",
            backgroundColor: "lightgray",
            padding: "10px",
          }}
        >
          Informacje o użytkowniku
        </h5>
        <img src={Person} className="card-img" alt="..." />
        <p className="card-text">
          Imię: {props.user.firstname} <br />
          Nazwisko: {props.user.lastname} <br />
          Data urodzenia: {props.user.date.toLocaleDateString()} <br />
        </p>
      </div>
    </div>
  );
};

export default Card;
