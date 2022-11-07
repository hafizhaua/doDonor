CREATE SEQUENCE req_id START 1111;

CREATE TABLE donor_req (
	id VARCHAR(100) DEFAULT 'DR' || NEXTVAL('req_id') PRIMARY KEY,
	patient_name VARCHAR(255) NOT NULL,
	blood_type VARCHAR(255) NOT NULL,
	bag_quantity INT CHECK(bag_quantity > 0) NOT NULL,
	donor_type VARCHAR(255) NOT NULL,
	region VARCHAR(255) NOT NULL,
	hospital_name VARCHAR(255) NOT NULL,
	cp_name VARCHAR(255) NOT NULL,
	cp_phone_number VARCHAR(255) NOT NULL
);


CREATE OR REPLACE FUNCTION donor_req_insert(
	_patient_name VARCHAR,
	_blood_type VARCHAR,
	_bag_quantity INT,
	_donor_type VARCHAR,
	_region VARCHAR,
	_hospital_name VARCHAR,
	_cp_name VARCHAR,
	_cp_phone_number VARCHAR
)
returns int AS
'
BEGIN
	INSERT INTO public.donor_req
	(
		patient_name,
		blood_type,
		bag_quantity,
		donor_type,
		region,
		hospital_name,
		cp_name,
		cp_phone_number
	)
	VALUES
	(
		_patient_name,
		_blood_type,
		_bag_quantity,
		_donor_type,
		_region,
		_hospital_name,
		_cp_name,
		_cp_phone_number
	);
	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END
'
LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION donor_req_select(
)
RETURNS TABLE
(
	_id VARCHAR,
	_patient_name VARCHAR,
	_blood_type VARCHAR,
	_bag_quantity INT,
	_donor_type VARCHAR,
	_region VARCHAR,
	_hospital_name VARCHAR,
	_cp_name VARCHAR,
	_cp_phone_number VARCHAR
)
LANGUAGE plpgsql
AS
'
BEGIN
	RETURN QUERY
	SELECT id, patient_name, blood_type, bag_quantity, donor_type, 
					region, hospital_name, cp_name, cp_phone_number FROM donor_req;
END
'

CREATE OR REPLACE FUNCTION donor_req_update
(
	_id VARCHAR,
	_patient_name VARCHAR,
	_blood_type VARCHAR,
	_bag_quantity INT,
	_donor_type VARCHAR,
	_region VARCHAR,
	_hospital_name VARCHAR,
	_cp_name VARCHAR,
	_cp_phone_number VARCHAR
)
RETURNS INT
AS
'
BEGIN
	UPDATE donor_req SET
		patient_name = _patient_name,
		blood_type = _blood_type,
		bag_quantity = _bag_quantity,
		donor_type = _donor_type,
		region = _region,
		hospital_name = _hospital_name,
		cp_name = _cp_name,
		cp_phone_number = _cp_phone_number
	WHERE id = _id;

	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END
'
LANGUAGE plpgsql

CREATE OR REPLACE FUNCTION donor_req_delete(_id VARCHAR)
RETURNS INT AS
'
BEGIN
	DELETE FROM public.donor_req
	WHERE id = _id;

	IF FOUND THEN
		RETURN 1;
	ELSE
		RETURN 0;
	END IF;
END
'
LANGUAGE plpgsql;