-- Delete
drop table menu.menu_items;

-- Create table
CREATE TABLE menu.menu_items (
  id SERIAL PRIMARY KEY NOT NULL,
  title varchar NOT NULL,
  description varchar,
  -- ingredients_table_id bigint NOT NULL,
  price_inc_vat numeric
);


-- Insert values
insert into menu.menu_items 
(title, description, price_inc_vat) 
values ('Vegan duck', 'Delicious vegan duck', 21.12);

-- Select data
select * from menu.menu_items;